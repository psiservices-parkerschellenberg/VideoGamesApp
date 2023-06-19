using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Developer { get; set; }
        public decimal Price { get; set; }
    }
}
