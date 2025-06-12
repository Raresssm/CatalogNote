using System;

namespace CatalogNote.Models
{
    [Serializable]
    public class Student
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Grupa { get; set; }

        public override string ToString() => $"{Nume} {Prenume}";
    }
}
