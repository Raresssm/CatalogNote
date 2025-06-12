using System;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentsMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new StudentForm())
                f.ShowDialog();
        }

        private void disciplineMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new DisciplinaForm())
                f.ShowDialog();
        }

        private void gradesMenuItem_Click(object sender, EventArgs e)
        {
            using (var f = new NoteForm())
                f.ShowDialog();
        }

        private void exportMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    CatalogLogic.ExportCsv(sfd.FileName);
                }
            }
        }
    }
}
