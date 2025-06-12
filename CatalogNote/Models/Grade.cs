using System;

namespace CatalogNote.Models
{
    [Serializable]
    public class Grade
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid StudentId { get; set; }
        public Guid DisciplineId { get; set; }
        public int Nota { get; set; }
        public DateTime DataNotarii { get; set; } = DateTime.Now;
    }
}
