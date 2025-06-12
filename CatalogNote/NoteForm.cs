using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class NoteForm : Form
    {
        private BindingList<Nota> list;
        public NoteForm()
        {
            InitializeComponent();
            list = new BindingList<Nota>(Program.Catalog.Notes);
            gridNotes.AutoGenerateColumns = false;
            gridNotes.DataSource = list;
            colStudent.DataSource = Program.Catalog.Students;
            colStudent.DisplayMember = "LastName";
            colStudent.ValueMember = "Id";
            colDisciplina.DataSource = Program.Catalog.Discipline;
            colDisciplina.DisplayMember = "Name";
            colDisciplina.ValueMember = "Id";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var n = new Nota { Id = GenerateId(), Timestamp = DateTime.Now };
            list.Add(n);
            Program.Catalog.Notes.Add(n);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (gridNotes.CurrentRow?.DataBoundItem is Nota n)
            {
                list.Remove(n);
                Program.Catalog.Notes.Remove(n);
            }
        }

        private int GenerateId()
        {
            return Program.Catalog.Notes.Any() ? Program.Catalog.Notes.Max(x => x.Id) + 1 : 1;
        }
    }
}
