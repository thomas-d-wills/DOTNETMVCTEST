using System.ComponentModel.DataAnnotations;

namespace TestApplication.DTOs
{
    public class GamesDTO
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; } = null!;
        [DataType(DataType.Date)]
        public DateTime? Release { get; set; }
        public string? Publisher { get; set; }



        public Games ToCompletedGames()
        {
            return new Games
            {
                ID = this.ID,
                Title = this.Title,
                Release = this.Release,
                Publisher = this.Publisher,
            };
        }

    }
}
