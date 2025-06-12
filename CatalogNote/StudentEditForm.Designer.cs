using System.Drawing;
using System.Windows.Forms;

namespace CatalogNote
{
    partial class StudentEditForm
    {
        private TextBox txtLast;
        private TextBox txtFirst;
        private TextBox txtEmail;
        private TextBox txtGroup;
        private Button okButton;
        private Button cancelButton;

        private void InitializeComponent()
        {
            this.txtLast = new TextBox();
            this.txtFirst = new TextBox();
            this.txtEmail = new TextBox();
            this.txtGroup = new TextBox();
            this.okButton = new Button();
            this.cancelButton = new Button();
            this.SuspendLayout();
            // txtLast
            this.txtLast.Location = new Point(12, 25);
            this.txtLast.Width = 260;
            // txtFirst
            this.txtFirst.Location = new Point(12, 65);
            this.txtFirst.Width = 260;
            // txtEmail
            this.txtEmail.Location = new Point(12, 105);
            this.txtEmail.Width = 260;
            // txtGroup
            this.txtGroup.Location = new Point(12, 145);
            this.txtGroup.Width = 260;
            // okButton
            this.okButton.Location = new Point(116, 180);
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // cancelButton
            this.cancelButton.Location = new Point(197, 180);
            this.cancelButton.Text = "Cancel";
            this.cancelButton.DialogResult = DialogResult.Cancel;
            // labels
            var lblLast = new Label { Text = "Last Name", Location = new Point(12, 7) };
            var lblFirst = new Label { Text = "First Name", Location = new Point(12, 47) };
            var lblEmail = new Label { Text = "Email", Location = new Point(12, 87) };
            var lblGroup = new Label { Text = "Group", Location = new Point(12, 127) };
            // form
            this.ClientSize = new Size(284, 221);
            this.Controls.Add(lblLast);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(lblFirst);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(lblGroup);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Text = "Student";
            this.AcceptButton = this.okButton;
            this.ResumeLayout(false);
        }
    }
}
