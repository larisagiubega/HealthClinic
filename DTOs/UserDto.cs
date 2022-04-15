
namespace HealthClinic.DTOs
{
    using HealthClinic.DTOs;

    public class UserDto : PersonDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public RightDto Rights { get; set; }
    }
}
