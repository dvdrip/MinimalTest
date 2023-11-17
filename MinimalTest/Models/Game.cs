namespace MinimalTest.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
