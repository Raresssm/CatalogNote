using System.Windows.Forms;

namespace CatalogNote
{
    partial class DisciplinaForm
    {
        private DataGridView gridDiscipline;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;

        private void InitializeComponent()
        {
            this.gridDiscipline = new DataGridView();
            this.addButton = new Button();
            this.editButton = new Button();
            this.deleteButton = new Button();
            this.SuspendLayout();
            // gridDiscipline
            this.gridDiscipline.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.gridDiscipline.Location = new System.Drawing.Point(12, 12);
            this.gridDiscipline.Size = new System.Drawing.Size(560, 350);
            this.gridDiscipline.AutoGenerateColumns = true;
            this.gridDiscipline.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // addButton
            this.addButton.Location = new System.Drawing.Point(12, 370);
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // editButton
            this.editButton.Location = new System.Drawing.Point(93, 370);
            this.editButton.Text = "Edit";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // deleteButton
            this.deleteButton.Location = new System.Drawing.Point(174, 370);
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // DisciplinaForm
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.gridDiscipline);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Text = "Discipline";
            this.ResumeLayout(false);
        }
    }
}
