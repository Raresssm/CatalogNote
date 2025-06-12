using System.Collections.Generic;
using CatalogNote.Models;

namespace CatalogNote.Data
{
    public static class DataStorage
    {
        public static List<Student> Students { get; } = new List<Student>();
        public static List<Discipline> Disciplines { get; } = new List<Discipline>();
        public static List<Grade> Grades { get; } = new List<Grade>();

        private static int _studentId;
        private static int _disciplineId;
        private static int _gradeId;

        public static Student AddStudent(string name)
        {
            var student = new Student { Id = ++_studentId, Name = name };
            Students.Add(student);
            return student;
        }

        public static Discipline AddDiscipline(string name)
        {
            var discipline = new Discipline { Id = ++_disciplineId, Name = name };
            Disciplines.Add(discipline);
            return discipline;
        }

        public static Grade AddGrade(Student student, Discipline discipline, double value)
        {
            var grade = new Grade { Id = ++_gradeId, Student = student, Discipline = discipline, Value = value, Date = System.DateTime.Now };
            Grades.Add(grade);
            return grade;
        }

        public static void RemoveStudent(Student student)
        {
            Students.Remove(student);
            Grades.RemoveAll(g => g.Student == student);
        }

        public static void RemoveDiscipline(Discipline discipline)
        {
            Disciplines.Remove(discipline);
            Grades.RemoveAll(g => g.Discipline == discipline);
        }

        public static void RemoveGrade(Grade grade)
        {
            Grades.Remove(grade);
        }
    }
}
