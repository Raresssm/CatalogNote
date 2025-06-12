using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CatalogNote.Models;

namespace CatalogNote.Forms
{
    public class AddGradeForm : Form
    {
        private ComboBox _students = new ComboBox { Left = 20, Top = 20, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
        private ComboBox _disciplines = new ComboBox { Left = 20, Top = 60, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
        private NumericUpDown _value = new NumericUpDown { Left = 20, Top = 100, Width = 200, Minimum = 1, Maximum = 10, DecimalPlaces = 1, Increment = 0.5M };
        private Button _ok = new Button { Text = "Ok", Left = 140, Top = 140, DialogResult = DialogResult.OK };

        public Student SelectedStudent => _students.SelectedItem as Student;
        public Discipline SelectedDiscipline => _disciplines.SelectedItem as Discipline;
        public double GradeValue => (double)_value.Value;

        public AddGradeForm(IEnumerable<Student> students, IEnumerable<Discipline> disciplines)
        {
            Text = "Add/Edit Grade";
            Width = 260;
            Height = 220;
            Controls.AddRange(new Control[] { _students, _disciplines, _value, _ok });
            _students.DataSource = students.ToList();
            _students.DisplayMember = "Name";
            _disciplines.DataSource = disciplines.ToList();
            _disciplines.DisplayMember = "Name";
            AcceptButton = _ok;
        }

        public void SetGrade(Grade grade)
        {
            _students.SelectedItem = grade.Student;
            _disciplines.SelectedItem = grade.Discipline;
            _value.Value = (decimal)grade.Value;
        }
    }
}
