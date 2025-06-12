using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class NotesForm : Form
    {
        private BindingList<Nota> _notes;

        public NotesForm()
        {
            InitializeComponent();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            _notes = new BindingList<Nota>(Program.Catalog.Notes);
            dataGridView1.AutoGenerateColumns = false;

            var colId = new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" };
            var colStudent = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "StudentId",
                DataSource = Program.Catalog.Students,
                DisplayMember = "DisplayName",
                ValueMember = "Id",
                HeaderText = "Student"
            };
            var colDiscipline = new DataGridViewComboBoxColumn
            {
                DataPropertyName = "DisciplinaId",
                DataSource = Program.Catalog.Discipline,
                DisplayMember = "Name",
                ValueMember = "Id",
                HeaderText = "Discipline"
            };
            var colValue = new DataGridViewTextBoxColumn { DataPropertyName = "Value", HeaderText = "Grade" };
            var colDate = new DataGridViewTextBoxColumn { DataPropertyName = "Date", HeaderText = "Date" };

            dataGridView1.Columns.AddRange(colId, colStudent, colDiscipline, colValue, colDate);
            dataGridView1.DataSource = _notes;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nextId = _notes.Any() ? _notes.Max(n => n.Id) + 1 : 1;
            _notes.Add(new Nota { Id = nextId, Date = DateTime.Now });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.DataBoundItem is Nota n)
                    _notes.Remove(n);
            }
        }
    }
}

