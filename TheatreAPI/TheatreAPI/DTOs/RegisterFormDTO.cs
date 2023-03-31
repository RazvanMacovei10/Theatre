using TheatreAPI.Models;

namespace TheatreAPI.DTOs
{
    public class RegisterFormDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public int TotalSeats { get; set; }
        public string Image { get; set; }
    }
}
