using System;
using System.Linq;
using System.Windows.Forms;
using CatalogNote.Data;
using CatalogNote.Models;
using CatalogNote.Utils;

namespace CatalogNote.Forms
{
    public class DisciplinesForm : Form
    {
        private DataGridView _grid = new DataGridView { Dock = DockStyle.Top, Height = 250 };
        private Button _add = new Button { Text = "Add", Left = 10, Top = 260 };
        private Button _edit = new Button { Text = "Edit", Left = 100, Top = 260 };
        private Button _delete = new Button { Text = "Delete", Left = 190, Top = 260 };

        public DisciplinesForm()
        {
            Text = "Disciplines";
            Width = 400;
            Height = 350;
            Controls.AddRange(new Control[] { _grid, _add, _edit, _delete });
            Load += (s, e) => RefreshGrid();
            _add.Click += (s, e) => AddDiscipline();
            _edit.Click += (s, e) => EditDiscipline();
            _delete.Click += (s, e) => DeleteDiscipline();
        }

        private void RefreshGrid()
        {
            _grid.DataSource = null;
            _grid.DataSource = DataStorage.Disciplines.Select(x => new { x.Id, x.Name }).ToList();
        }

        private Discipline SelectedDiscipline()
        {
            if (_grid.CurrentRow?.DataBoundItem is object item)
            {
                int id = (int)item.GetType().GetProperty("Id").GetValue(item, null);
                return DataStorage.Disciplines.FirstOrDefault(d => d.Id == id);
            }
            return null;
        }

        private void AddDiscipline()
        {
            string name = Prompt.ShowDialog("Name", "Add Discipline");
            if (!string.IsNullOrWhiteSpace(name))
            {
                DataStorage.AddDiscipline(name);
                RefreshGrid();
            }
        }

        private void EditDiscipline()
        {
            var discipline = SelectedDiscipline();
            if (discipline == null) return;
            string name = Prompt.ShowDialog("Name", "Edit Discipline");
            if (!string.IsNullOrWhiteSpace(name))
            {
                discipline.Name = name;
                RefreshGrid();
            }
        }

        private void DeleteDiscipline()
        {
            var discipline = SelectedDiscipline();
            if (discipline == null) return;
            DataStorage.RemoveDiscipline(discipline);
            RefreshGrid();
        }
    }
}
