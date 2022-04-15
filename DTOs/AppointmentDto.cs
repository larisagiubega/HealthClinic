

namespace HealthClinic.DTOs
{
    using System;
    public class AppointmentDto : PersonDto
    {
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public UserDto Doctor { get; set; }
    }
}
