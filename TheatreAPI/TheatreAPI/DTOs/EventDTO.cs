namespace TheatreAPI.DTOs
{
    public class EventDTO
    {
        public int Id { get; set; }
        public DateTime Datetime { get; set; }
        public int AvailableSeats { get; set; }
        public string TheatreName { get; set; }
        public PlayDTO play { get; set; }
    }
}
