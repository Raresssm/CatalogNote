using System;

namespace CatalogNote.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Discipline Discipline { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }
    }
}
