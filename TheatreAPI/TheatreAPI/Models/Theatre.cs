namespace TheatreAPI.Models
{
    public class Theatre
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Address Address { get; set; }
        public List<Event> Events { get; set; }
        public int TotalSeats { get; set; }
        public byte[] Image { get; set; }
    }
}
