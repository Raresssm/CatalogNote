using System.Drawing;
using System.Windows.Forms;

namespace CatalogNote
{
    partial class DisciplinaEditForm
    {
        private TextBox txtName;
        private TextBox txtAcronym;
        private ComboBox comboType;
        private Button okButton;
        private Button cancelButton;

        private void InitializeComponent()
        {
            this.txtName = new TextBox();
            this.txtAcronym = new TextBox();
            this.comboType = new ComboBox();
            this.okButton = new Button();
            this.cancelButton = new Button();
            this.SuspendLayout();
            // txtName
            this.txtName.Location = new Point(12, 25);
            this.txtName.Width = 260;
            // txtAcronym
            this.txtAcronym.Location = new Point(12, 65);
            this.txtAcronym.Width = 260;
            // comboType
            this.comboType.Location = new Point(12, 105);
            this.comboType.Width = 260;
            this.comboType.DropDownStyle = ComboBoxStyle.DropDownList;
            // okButton
            this.okButton.Location = new Point(116, 145);
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // cancelButton
            this.cancelButton.Location = new Point(197, 145);
            this.cancelButton.Text = "Cancel";
            this.cancelButton.DialogResult = DialogResult.Cancel;
            // labels
            var lblName = new Label { Text = "Name", Location = new Point(12, 7) };
            var lblAcronym = new Label { Text = "Acronym", Location = new Point(12, 47) };
            var lblType = new Label { Text = "Type", Location = new Point(12, 87) };
            // form
            this.ClientSize = new Size(284, 181);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(lblAcronym);
            this.Controls.Add(this.txtAcronym);
            this.Controls.Add(lblType);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Text = "Discipline";
            this.AcceptButton = this.okButton;
            this.ResumeLayout(false);
        }
    }
}
