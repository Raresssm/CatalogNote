using System;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class StudentEditForm : Form
    {
        public Student Student { get; }
        public StudentEditForm(Student student)
        {
            InitializeComponent();
            Student = student;
            txtLast.Text = Student.LastName;
            txtFirst.Text = Student.FirstName;
            txtEmail.Text = Student.Email;
            txtGroup.Text = Student.Group;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Student.LastName = txtLast.Text.Trim();
            Student.FirstName = txtFirst.Text.Trim();
            Student.Email = txtEmail.Text.Trim();
            Student.Group = txtGroup.Text.Trim();
            DialogResult = DialogResult.OK;
        }
    }
}
