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

        private void studentsMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new StudentsForm())
            {
                form.ShowDialog();
            }
        }

        private void disciplineMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new DisciplineForm())
            {
                form.ShowDialog();
            }
        }

        private void notesMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new NotesForm())
            {
                form.ShowDialog();
            }
        }

        private void exportMenuItem_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    CsvExporter.Export(sfd.FileName);
                    MessageBox.Show("Export completed.");
                }
            }
        }

        private void statisticsMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new StatisticsForm())
            {
                form.ShowDialog();
            }
        }
    }
}
