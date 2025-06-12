using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CatalogNote
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Disciplina
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    }

    [DataContract]
    public class Nota
    {
        [DataMember]
        public int StudentId { get; set; }

        [DataMember]
        public int DisciplinaId { get; set; }

        [DataMember]
        public double Value { get; set; }
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
