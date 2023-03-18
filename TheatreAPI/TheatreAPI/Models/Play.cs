namespace TheatreAPI.Models
{
    public class Play
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public PlayType Type { get; set; }
        public List<Actor> Actors { get; set; }
        public byte[] Image { get; set; }

    }
}
