using TheatreAPI.Models;

namespace TheatreAPI.DTOs
{
    public class TheathreDTO
    {
        public Address Address { get; set; }
        public UserDTO User { get; set; }
        public int TotalSeats { get; set; }
        public string Image { get; set; }
        public List<EventDTO> Events { get; set; }
    }
}
