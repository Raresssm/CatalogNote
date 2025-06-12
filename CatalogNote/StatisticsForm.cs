using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            cbStudent.DataSource = Program.Catalog.Students;
            cbStudent.DisplayMember = "DisplayName";
            cbStudent.ValueMember = "Id";

            cbDiscipline.DataSource = Program.Catalog.Discipline;
            cbDiscipline.DisplayMember = "Name";
            cbDiscipline.ValueMember = "Id";

            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var notes = Program.Catalog.Notes.AsEnumerable();
            if (cbStudent.SelectedItem is Student student)
            {
                notes = notes.Where(n => n.StudentId == student.Id);
                lblAverage.Text = CatalogLogic.GetStudentAverage(student.Id).ToString("0.00");
            }
            else
            {
                lblAverage.Text = "-";
            }

            if (cbDiscipline.SelectedItem is Disciplina disciplina)
            {
                notes = notes.Where(n => n.DisciplinaId == disciplina.Id);

                if (cbStudent.SelectedItem is Student s)
                    lblStatus.Text = CatalogLogic.IsDisciplinePassed(s.Id, disciplina.Id) ? "Passed" : "Failed";
                else
                    lblStatus.Text = "-";
            }
            else
            {
                lblStatus.Text = "-";
            }

            var table = notes.Select(n => new
            {
                Student = Program.Catalog.Students.First(st => st.Id == n.StudentId).DisplayName,
                Discipline = Program.Catalog.Discipline.First(d => d.Id == n.DisciplinaId).Name,
                Grade = n.Value,
                Date = n.Date.ToString("yyyy-MM-dd")
            }).ToList();

            dataGridView1.DataSource = table;
        }

        private void cbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cbDiscipline_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
