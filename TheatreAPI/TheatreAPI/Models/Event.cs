namespace TheatreAPI.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int AvailableSeats { get; set; }
        public int TheatreId { get; set; }
        public Theatre Theatre { get; set; }
        public int PlayId { get; set; }
        public Play Play { get; set; }
    }
}
