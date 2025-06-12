using System;
using System.IO;
using System.Linq;

namespace CatalogNote
{
    internal static class CsvExporter
    {
        public static void Export(string path)
        {
            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine("Student,Discipline,Grade,Date");
                foreach (var note in Program.Catalog.Notes)
                {
                    var student = Program.Catalog.Students.FirstOrDefault(s => s.Id == note.StudentId);
                    var discipline = Program.Catalog.Discipline.FirstOrDefault(d => d.Id == note.DisciplinaId);
                    writer.WriteLine($"{student?.DisplayName},{discipline?.Name},{note.Value},{note.Date:yyyy-MM-dd}");
                }
            }
        }
    }
}

