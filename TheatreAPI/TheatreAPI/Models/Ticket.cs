namespace TheatreAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
        public float Price { get; set; }
    }
}
