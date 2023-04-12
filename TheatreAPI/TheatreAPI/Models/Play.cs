namespace TheatreAPI.Models
{
    public class Play
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public int PlayTypeId { get; set; }
        public PlayType Type { get; set; }
        public string Actors { get; set; }

    }
}
