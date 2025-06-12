using System.Windows.Forms;

namespace CatalogNote
{
    partial class Form1
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentsMenuItem;
        private ToolStripMenuItem disciplineMenuItem;
        private ToolStripMenuItem gradesMenuItem;
        private ToolStripMenuItem exportMenuItem;

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.studentsMenuItem = new ToolStripMenuItem();
            this.disciplineMenuItem = new ToolStripMenuItem();
            this.gradesMenuItem = new ToolStripMenuItem();
            this.exportMenuItem = new ToolStripMenuItem();
            this.SuspendLayout();
            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
                this.studentsMenuItem,
                this.disciplineMenuItem,
                this.gradesMenuItem,
                this.exportMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            // studentsMenuItem
            this.studentsMenuItem.Text = "Students";
            this.studentsMenuItem.Click += new System.EventHandler(this.studentsMenuItem_Click);
            // disciplineMenuItem
            this.disciplineMenuItem.Text = "Discipline";
            this.disciplineMenuItem.Click += new System.EventHandler(this.disciplineMenuItem_Click);
            // gradesMenuItem
            this.gradesMenuItem.Text = "Grades";
            this.gradesMenuItem.Click += new System.EventHandler(this.gradesMenuItem_Click);
            // exportMenuItem
            this.exportMenuItem.Text = "Export CSV";
            this.exportMenuItem.Click += new System.EventHandler(this.exportMenuItem_Click);
            // Form1
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Catalog";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
