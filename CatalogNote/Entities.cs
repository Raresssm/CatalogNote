using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CatalogNote
{
    public enum EvaluationType
    {
        Exam,
        Colloquium
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Group { get; set; }
    }

    [DataContract]
    public class Disciplina
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Acronym { get; set; }

        [DataMember]
        public EvaluationType EvaluationType { get; set; }
    }

    [DataContract]
    public class Nota
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int StudentId { get; set; }

        [DataMember]
        public int DisciplinaId { get; set; }

        [DataMember]
        public int Value { get; set; }

        [DataMember]
        public DateTime Timestamp { get; set; }
    }

    [DataContract]
    public class CatalogData
    {
        [DataMember]
        public List<Student> Students { get; set; } = new List<Student>();

        [DataMember]
        public List<Disciplina> Discipline { get; set; } = new List<Disciplina>();

        [DataMember]
        public List<Nota> Notes { get; set; } = new List<Nota>();
    }
}
