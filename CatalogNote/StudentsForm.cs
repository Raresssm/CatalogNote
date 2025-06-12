using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class StudentsForm : Form
    {
        private BindingList<Student> _students;

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            _students = new BindingList<Student>(Program.Catalog.Students);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nextId = _students.Any() ? _students.Max(s => s.Id) + 1 : 1;
            _students.Add(new Student { Id = nextId });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.DataBoundItem is Student s)
                    _students.Remove(s);
            }
        }
    }
}

