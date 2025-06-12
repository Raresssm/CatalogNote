using System.Linq;

namespace CatalogNote
{
    internal static class CatalogLogic
    {
        public static double GetStudentAverage(int studentId)
        {
            var notes = Program.Catalog.Notes
                .Where(n => n.StudentId == studentId)
                .ToList();
            if (!notes.Any())
                return 0;
            return notes.Average(n => n.Value);
        }

        public static bool IsDisciplinePassed(int studentId, int disciplinaId, double passingGrade = 5.0)
        {
            var notes = Program.Catalog.Notes
                .Where(n => n.StudentId == studentId && n.DisciplinaId == disciplinaId)
                .ToList();
            if (!notes.Any())
                return false;
            return notes.Average(n => n.Value) >= passingGrade;
        }
    }
}
