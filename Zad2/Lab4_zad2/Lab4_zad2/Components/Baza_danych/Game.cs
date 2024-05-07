using System.ComponentModel.DataAnnotations;

namespace Lab4_zad2.Components.Baza_danych
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? RelaseDate { get; set; }
        public float? Rate { get; set; }
        public string? url { get; set; }
    }
}
