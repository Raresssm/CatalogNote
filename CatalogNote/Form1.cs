using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataStore.Load();

            dgvStudents.DataSource = DataStore.Students;
            dgvDisciplines.DataSource = DataStore.Disciplines;

            dgvGrades.AutoGenerateColumns = false;
            var studentCol = new DataGridViewComboBoxColumn();
            studentCol.HeaderText = "Student";
            studentCol.DataPropertyName = "StudentId";
            studentCol.ValueMember = "Id";
            studentCol.DisplayMember = "ToString";
            studentCol.DataSource = DataStore.Students;
            dgvGrades.Columns.Add(studentCol);

            var discCol = new DataGridViewComboBoxColumn();
            discCol.HeaderText = "Disciplina";
            discCol.DataPropertyName = "DisciplineId";
            discCol.ValueMember = "Id";
            discCol.DisplayMember = "Nume";
            discCol.DataSource = DataStore.Disciplines;
            dgvGrades.Columns.Add(discCol);

            var gradeCol = new DataGridViewTextBoxColumn();
            gradeCol.DataPropertyName = "Nota";
            gradeCol.HeaderText = "Nota";
            dgvGrades.Columns.Add(gradeCol);

            var dateCol = new DataGridViewTextBoxColumn();
            dateCol.DataPropertyName = "DataNotarii";
            dateCol.HeaderText = "Data";
            dgvGrades.Columns.Add(dateCol);

            dgvGrades.DataSource = DataStore.Grades;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataStore.Save();
            MessageBox.Show("Date salvate.");
        }
    }
}
