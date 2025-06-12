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

        private void btnStudents_Click(object sender, EventArgs e)
        {
            using (var f = new Forms.StudentsForm())
                f.ShowDialog();
        }

        private void btnDisciplines_Click(object sender, EventArgs e)
        {
            using (var f = new Forms.DisciplinesForm())
                f.ShowDialog();
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            using (var f = new Forms.GradesForm())
                f.ShowDialog();
        }
    }
}
