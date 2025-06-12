using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CatalogNote
{
    internal static class CatalogLogic
    {
        public static double GetStudentAverage(int studentId)
        {
            var notes = Program.Catalog.Notes.Where(n => n.StudentId == studentId);
            if (!notes.Any())
                return 0;
            return notes.Average(n => n.Value);
        }

        public static bool IsDisciplinePassed(int studentId, int disciplinaId)
        {
            var note = Program.Catalog.Notes
                .Where(n => n.StudentId == studentId && n.DisciplinaId == disciplinaId)
                .OrderByDescending(n => n.Timestamp)
                .FirstOrDefault();
            return note != null && note.Value >= 5;
        }

        public static void ExportCsv(string path)
        {
            var sb = new StringBuilder();
            sb.AppendLine("StudentId,DisciplinaId,Value,Timestamp");
            foreach (var n in Program.Catalog.Notes)
            {
                sb.AppendLine($"{n.StudentId},{n.DisciplinaId},{n.Value},{n.Timestamp:yyyy-MM-dd}");
            }
            File.WriteAllText(path, sb.ToString());
        }
    }
}
