using System;
using System.Linq;
using System.Windows.Forms;
using CatalogNote.Data;
using CatalogNote.Models;
using CatalogNote.Utils;

namespace CatalogNote.Forms
{
    public class StudentsForm : Form
    {
        private DataGridView _grid = new DataGridView { Dock = DockStyle.Top, Height = 250 };
        private Button _add = new Button { Text = "Add", Left = 10, Top = 260 };
        private Button _edit = new Button { Text = "Edit", Left = 100, Top = 260 };
        private Button _delete = new Button { Text = "Delete", Left = 190, Top = 260 };

        public StudentsForm()
        {
            Text = "Students";
            Width = 400;
            Height = 350;
            Controls.AddRange(new Control[] { _grid, _add, _edit, _delete });
            Load += (s, e) => RefreshGrid();
            _add.Click += (s, e) => AddStudent();
            _edit.Click += (s, e) => EditStudent();
            _delete.Click += (s, e) => DeleteStudent();
        }

        private void RefreshGrid()
        {
            _grid.DataSource = null;
            _grid.DataSource = DataStorage.Students.Select(x => new { x.Id, x.Name }).ToList();
        }

        private Student SelectedStudent()
        {
            if (_grid.CurrentRow?.DataBoundItem is object item)
            {
                int id = (int)item.GetType().GetProperty("Id").GetValue(item, null);
                return DataStorage.Students.FirstOrDefault(s => s.Id == id);
            }
            return null;
        }

        private void AddStudent()
        {
            string name = Prompt.ShowDialog("Name", "Add Student");
            if (!string.IsNullOrWhiteSpace(name))
            {
                DataStorage.AddStudent(name);
                RefreshGrid();
            }
        }

        private void EditStudent()
        {
            var student = SelectedStudent();
            if (student == null) return;
            string name = Prompt.ShowDialog("Name", "Edit Student");
            if (!string.IsNullOrWhiteSpace(name))
            {
                student.Name = name;
                RefreshGrid();
            }
        }

        private void DeleteStudent()
        {
            var student = SelectedStudent();
            if (student == null) return;
            DataStorage.RemoveStudent(student);
            RefreshGrid();
        }
    }
}
