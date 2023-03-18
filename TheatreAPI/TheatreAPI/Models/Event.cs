namespace TheatreAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public Play Play { get; set; }
        public DateTime DateTime { get; set; }
        public Theatre Theatre { get; set; }
        public int AvailableSeats { get; set; }
    }
}
