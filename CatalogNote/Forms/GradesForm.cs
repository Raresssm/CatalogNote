using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CatalogNote.Data;
using CatalogNote.Models;

namespace CatalogNote.Forms
{
    public class GradesForm : Form
    {
        private ComboBox _filterStudent = new ComboBox { Left = 10, Top = 10, Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
        private ComboBox _filterDiscipline = new ComboBox { Left = 170, Top = 10, Width = 150, DropDownStyle = ComboBoxStyle.DropDownList };
        private DataGridView _grid = new DataGridView { Left = 10, Top = 40, Width = 500, Height = 220 };
        private Button _add = new Button { Text = "Add", Left = 10, Top = 270 };
        private Button _edit = new Button { Text = "Edit", Left = 100, Top = 270 };
        private Button _delete = new Button { Text = "Delete", Left = 190, Top = 270 };
        private Button _export = new Button { Text = "Export CSV", Left = 280, Top = 270 };
        private Label _avgLabel = new Label { Left = 380, Top = 274, Width = 200 };

        public GradesForm()
        {
            Text = "Grades";
            Width = 540;
            Height = 350;
            Controls.AddRange(new Control[] { _filterStudent, _filterDiscipline, _grid, _add, _edit, _delete, _export, _avgLabel });
            Load += (s, e) => Initialize();
            _filterStudent.SelectedIndexChanged += (s, e) => RefreshGrid();
            _filterDiscipline.SelectedIndexChanged += (s, e) => RefreshGrid();
            _add.Click += (s, e) => AddGrade();
            _edit.Click += (s, e) => EditGrade();
            _delete.Click += (s, e) => DeleteGrade();
            _export.Click += (s, e) => ExportCsv();
        }

        private void Initialize()
        {
            _filterStudent.Items.Add("All");
            foreach (var s in DataStorage.Students)
                _filterStudent.Items.Add(s);
            _filterStudent.DisplayMember = "Name";
            _filterStudent.SelectedIndex = 0;

            _filterDiscipline.Items.Add("All");
            foreach (var d in DataStorage.Disciplines)
                _filterDiscipline.Items.Add(d);
            _filterDiscipline.DisplayMember = "Name";
            _filterDiscipline.SelectedIndex = 0;
            RefreshGrid();
        }

        private IEnumerable<Grade> FilteredGrades()
        {
            IEnumerable<Grade> grades = DataStorage.Grades;
            if (_filterStudent.SelectedItem is Student s)
                grades = grades.Where(g => g.Student == s);
            if (_filterDiscipline.SelectedItem is Discipline d)
                grades = grades.Where(g => g.Discipline == d);
            return grades;
        }

        private void RefreshGrid()
        {
            var grades = FilteredGrades().ToList();
            _grid.DataSource = null;
            _grid.DataSource = grades.Select(g => new
            {
                g.Id,
                Student = g.Student.Name,
                Discipline = g.Discipline.Name,
                g.Value,
                Date = g.Date
            }).ToList();
            double avg = grades.Any() ? grades.Average(g => g.Value) : 0;
            _avgLabel.Text = $"Average: {avg:F2}";
        }

        private Grade SelectedGrade()
        {
            if (_grid.CurrentRow?.DataBoundItem is object item)
            {
                int id = (int)item.GetType().GetProperty("Id").GetValue(item, null);
                return DataStorage.Grades.FirstOrDefault(g => g.Id == id);
            }
            return null;
        }

        private void AddGrade()
        {
            var form = new AddGradeForm(DataStorage.Students, DataStorage.Disciplines);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataStorage.AddGrade(form.SelectedStudent, form.SelectedDiscipline, form.GradeValue);
                RefreshGrid();
            }
        }

        private void EditGrade()
        {
            var grade = SelectedGrade();
            if (grade == null) return;
            var form = new AddGradeForm(DataStorage.Students, DataStorage.Disciplines);
            form.SetGrade(grade);
            if (form.ShowDialog() == DialogResult.OK)
            {
                grade.Student = form.SelectedStudent;
                grade.Discipline = form.SelectedDiscipline;
                grade.Value = form.GradeValue;
                RefreshGrid();
            }
        }

        private void DeleteGrade()
        {
            var grade = SelectedGrade();
            if (grade == null) return;
            DataStorage.RemoveGrade(grade);
            RefreshGrid();
        }

        private void ExportCsv()
        {
            SaveFileDialog dlg = new SaveFileDialog { Filter = "CSV files|*.csv" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var sb = new StringBuilder();
                sb.AppendLine("Student,Discipline,Value,Date");
                foreach (var g in FilteredGrades())
                {
                    sb.AppendLine($"{g.Student.Name},{g.Discipline.Name},{g.Value},{g.Date:yyyy-MM-dd}");
                }
                File.WriteAllText(dlg.FileName, sb.ToString());
            }
        }
    }
}
