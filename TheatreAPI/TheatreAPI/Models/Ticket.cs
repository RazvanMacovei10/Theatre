namespace TheatreAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
