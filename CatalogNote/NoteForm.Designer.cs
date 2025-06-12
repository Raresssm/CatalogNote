using System.Windows.Forms;

namespace CatalogNote
{
    partial class NoteForm
    {
        private DataGridView gridNotes;
        private DataGridViewComboBoxColumn colStudent;
        private DataGridViewComboBoxColumn colDisciplina;
        private DataGridViewTextBoxColumn colValue;
        private DataGridViewTextBoxColumn colTimestamp;
        private Button addButton;
        private Button deleteButton;

        private void InitializeComponent()
        {
            this.gridNotes = new DataGridView();
            this.colStudent = new DataGridViewComboBoxColumn();
            this.colDisciplina = new DataGridViewComboBoxColumn();
            this.colValue = new DataGridViewTextBoxColumn();
            this.colTimestamp = new DataGridViewTextBoxColumn();
            this.addButton = new Button();
            this.deleteButton = new Button();
            this.SuspendLayout();
            // gridNotes
            this.gridNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.gridNotes.Location = new System.Drawing.Point(12, 12);
            this.gridNotes.Size = new System.Drawing.Size(560, 350);
            this.gridNotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridNotes.Columns.AddRange(new DataGridViewColumn[] {
                this.colStudent,
                this.colDisciplina,
                this.colValue,
                this.colTimestamp});
            // columns
            this.colStudent.HeaderText = "Student";
            this.colStudent.DataPropertyName = "StudentId";
            this.colDisciplina.HeaderText = "Discipline";
            this.colDisciplina.DataPropertyName = "DisciplinaId";
            this.colValue.HeaderText = "Grade";
            this.colValue.DataPropertyName = "Value";
            this.colTimestamp.HeaderText = "Date";
            this.colTimestamp.ReadOnly = true;
            this.colTimestamp.DataPropertyName = "Timestamp";
            // addButton
            this.addButton.Location = new System.Drawing.Point(12, 370);
            this.addButton.Text = "Add";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // deleteButton
            this.deleteButton.Location = new System.Drawing.Point(93, 370);
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // NoteForm
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.gridNotes);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Text = "Grades";
            this.ResumeLayout(false);
        }
    }
}
