using System;

namespace CatalogNote.Models
{
    [Serializable]
    public class Discipline
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nume { get; set; }
        public string Acronym { get; set; }
        public string TipEvaluare { get; set; }

        public override string ToString() => Nume;
    }
}
