using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class DisciplineForm : Form
    {
        private BindingList<Disciplina> _discipline;

        public DisciplineForm()
        {
            InitializeComponent();
        }

        private void DisciplineForm_Load(object sender, EventArgs e)
        {
            _discipline = new BindingList<Disciplina>(Program.Catalog.Discipline);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = _discipline;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int nextId = _discipline.Any() ? _discipline.Max(d => d.Id) + 1 : 1;
            _discipline.Add(new Disciplina { Id = nextId });
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.DataBoundItem is Disciplina d)
                    _discipline.Remove(d);
            }
        }
    }
}

