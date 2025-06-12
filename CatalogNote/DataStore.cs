using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;
using CatalogNote.Models;

namespace CatalogNote
{
    public static class DataStore
    {
        private const string FileName = "data.json";

        public static BindingList<Student> Students { get; private set; } = new BindingList<Student>();
        public static BindingList<Discipline> Disciplines { get; private set; } = new BindingList<Discipline>();
        public static BindingList<Grade> Grades { get; private set; } = new BindingList<Grade>();

        private class PersistedData
        {
            public List<Student> Students { get; set; } = new List<Student>();
            public List<Discipline> Disciplines { get; set; } = new List<Discipline>();
            public List<Grade> Grades { get; set; } = new List<Grade>();
        }

        public static void Load()
        {
            if (File.Exists(FileName))
            {
                var json = File.ReadAllText(FileName);
                var data = JsonSerializer.Deserialize<PersistedData>(json);
                Students = new BindingList<Student>(data?.Students ?? new List<Student>());
                Disciplines = new BindingList<Discipline>(data?.Disciplines ?? new List<Discipline>());
                Grades = new BindingList<Grade>(data?.Grades ?? new List<Grade>());
            }
        }

        public static void Save()
        {
            var data = new PersistedData
            {
                Students = new List<Student>(Students),
                Disciplines = new List<Discipline>(Disciplines),
                Grades = new List<Grade>(Grades)
            };
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FileName, json);
        }
    }
}
