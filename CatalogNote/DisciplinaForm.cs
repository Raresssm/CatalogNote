using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class DisciplinaForm : Form
    {
        private BindingList<Disciplina> list;
        public DisciplinaForm()
        {
            InitializeComponent();
            list = new BindingList<Disciplina>(Program.Catalog.Discipline);
            gridDiscipline.DataSource = list;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var d = new Disciplina { Id = GenerateId() };
            using (var f = new DisciplinaEditForm(d))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Program.Catalog.Discipline.Add(d);
                    list.ResetBindings();
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (gridDiscipline.CurrentRow?.DataBoundItem is Disciplina d)
            {
                var copy = new Disciplina
                {
                    Id = d.Id,
                    Name = d.Name,
                    Acronym = d.Acronym,
                    EvaluationType = d.EvaluationType
                };
                using (var f = new DisciplinaEditForm(copy))
                {
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        d.Name = copy.Name;
                        d.Acronym = copy.Acronym;
                        d.EvaluationType = copy.EvaluationType;
                        list.ResetBindings();
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (gridDiscipline.CurrentRow?.DataBoundItem is Disciplina d)
            {
                Program.Catalog.Discipline.Remove(d);
                list.ResetBindings();
            }
        }

        private int GenerateId()
        {
            return Program.Catalog.Discipline.Any() ? Program.Catalog.Discipline.Max(x => x.Id) + 1 : 1;
        }
    }
}
