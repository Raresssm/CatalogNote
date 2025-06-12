using System.Windows.Forms;

namespace CatalogNote
{
    partial class StudentForm
    {
        private DataGridView gridStudents;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;

        private void InitializeComponent()
        {
            this.gridStudents = new DataGridView();
            this.addButton = new Button();
            this.editButton = new Button();
            this.deleteButton = new Button();
            this.SuspendLayout();
            // gridStudents
            this.gridStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.gridStudents.Location = new System.Drawing.Point(12, 12);
            this.gridStudents.Size = new System.Drawing.Size(560, 350);
            this.gridStudents.AutoGenerateColumns = true;
            this.gridStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            // StudentForm
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Text = "Students";
            this.ResumeLayout(false);
        }
    }
}
