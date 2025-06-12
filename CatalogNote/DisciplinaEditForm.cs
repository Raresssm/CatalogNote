using System;
using System.Windows.Forms;

namespace CatalogNote
{
    public partial class DisciplinaEditForm : Form
    {
        public Disciplina Disciplina { get; }
        public DisciplinaEditForm(Disciplina disciplina)
        {
            InitializeComponent();
            Disciplina = disciplina;
            txtName.Text = disciplina.Name;
            txtAcronym.Text = disciplina.Acronym;
            comboType.DataSource = Enum.GetValues(typeof(EvaluationType));
            comboType.SelectedItem = disciplina.EvaluationType;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Disciplina.Name = txtName.Text.Trim();
            Disciplina.Acronym = txtAcronym.Text.Trim();
            Disciplina.EvaluationType = (EvaluationType)comboType.SelectedItem;
            DialogResult = DialogResult.OK;
        }
    }
}
