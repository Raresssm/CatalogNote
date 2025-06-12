using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class StudentForm : Form
    {
        private BindingList<Student> list;

        public StudentForm()
        {
            InitializeComponent();
            list = new BindingList<Student>(Program.Catalog.Students);
            gridStudents.DataSource = list;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var s = new Student { Id = GenerateId() };
            using (var f = new StudentEditForm(s))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Program.Catalog.Students.Add(s);
                    list.ResetBindings();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (gridStudents.CurrentRow?.DataBoundItem is Student s)
            {
                Program.Catalog.Students.Remove(s);
                list.ResetBindings();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (gridStudents.CurrentRow?.DataBoundItem is Student s)
            {
                var copy = new Student
                {
                    Id = s.Id,
                    LastName = s.LastName,
                    FirstName = s.FirstName,
                    Email = s.Email,
                    Group = s.Group
                };
                using (var f = new StudentEditForm(copy))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        s.LastName = copy.LastName;
                        s.FirstName = copy.FirstName;
                        s.Email = copy.Email;
                        s.Group = copy.Group;
                        list.ResetBindings();
                    }
                }
            }
        }

        private int GenerateId()
        {
            return Program.Catalog.Students.Any() ? Program.Catalog.Students.Max(x => x.Id) + 1 : 1;
        }
    }
}
