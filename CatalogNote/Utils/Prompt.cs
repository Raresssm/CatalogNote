using System.Drawing;
using System.Windows.Forms;

namespace CatalogNote.Utils
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                Text = caption,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmation = new Button() { Text = "Ok", Left = 280, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;
            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : null;
        }
    }
}
