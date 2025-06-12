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
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnDisciplines;
        private System.Windows.Forms.Button btnGrades;

        private void InitializeComponent()
        {
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnDisciplines = new System.Windows.Forms.Button();
            this.btnGrades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(30, 30);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(120, 40);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnDisciplines
            // 
            this.btnDisciplines.Location = new System.Drawing.Point(30, 80);
            this.btnDisciplines.Name = "btnDisciplines";
            this.btnDisciplines.Size = new System.Drawing.Size(120, 40);
            this.btnDisciplines.TabIndex = 1;
            this.btnDisciplines.Text = "Disciplines";
            this.btnDisciplines.UseVisualStyleBackColor = true;
            this.btnDisciplines.Click += new System.EventHandler(this.btnDisciplines_Click);
            // 
            // btnGrades
            // 
            this.btnGrades.Location = new System.Drawing.Point(30, 130);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(120, 40);
            this.btnGrades.TabIndex = 2;
            this.btnGrades.Text = "Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 200);
            this.Controls.Add(this.btnGrades);
            this.Controls.Add(this.btnDisciplines);
            this.Controls.Add(this.btnStudents);
            this.Name = "Form1";
            this.Text = "Catalog Note";
            this.ResumeLayout(false);
        }

        #endregion
    }
}

