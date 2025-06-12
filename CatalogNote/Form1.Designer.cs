namespace CatalogNote
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.tabDisciplines = new System.Windows.Forms.TabPage();
            this.tabGrades = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvDisciplines = new System.Windows.Forms.DataGridView();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.tabDisciplines.SuspendLayout();
            this.tabGrades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();

            // tabControl1
            this.tabControl1.Controls.Add(this.tabStudents);
            this.tabControl1.Controls.Add(this.tabDisciplines);
            this.tabControl1.Controls.Add(this.tabGrades);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 421);
            // tabStudents
            this.tabStudents.Controls.Add(this.dgvStudents);
            this.tabStudents.Location = new System.Drawing.Point(4, 22);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(792, 395);
            this.tabStudents.Text = "Studenți";
            this.tabStudents.UseVisualStyleBackColor = true;
            // dgvStudents
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.AutoGenerateColumns = true;
            this.dgvStudents.Location = new System.Drawing.Point(3, 3);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(786, 389);
            // tabDisciplines
            this.tabDisciplines.Controls.Add(this.dgvDisciplines);
            this.tabDisciplines.Location = new System.Drawing.Point(4, 22);
            this.tabDisciplines.Name = "tabDisciplines";
            this.tabDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisciplines.Size = new System.Drawing.Size(792, 395);
            this.tabDisciplines.Text = "Discipline";
            this.tabDisciplines.UseVisualStyleBackColor = true;
            // dgvDisciplines
            this.dgvDisciplines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDisciplines.AutoGenerateColumns = true;
            this.dgvDisciplines.Location = new System.Drawing.Point(3, 3);
            this.dgvDisciplines.Name = "dgvDisciplines";
            this.dgvDisciplines.Size = new System.Drawing.Size(786, 389);
            // tabGrades
            this.tabGrades.Controls.Add(this.dgvGrades);
            this.tabGrades.Location = new System.Drawing.Point(4, 22);
            this.tabGrades.Name = "tabGrades";
            this.tabGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrades.Size = new System.Drawing.Size(792, 395);
            this.tabGrades.Text = "Note";
            this.tabGrades.UseVisualStyleBackColor = true;
            // dgvGrades
            this.dgvGrades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrades.Location = new System.Drawing.Point(3, 3);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.Size = new System.Drawing.Size(786, 389);
            // btnSave
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Location = new System.Drawing.Point(0, 421);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(800, 29);
            this.btnSave.Text = "Salvează";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Catalog Note";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabDisciplines.ResumeLayout(false);
            this.tabGrades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabDisciplines;
        private System.Windows.Forms.TabPage tabGrades;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvDisciplines;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Button btnSave;

        #endregion
    }
}

