
using System;

namespace HealthClinic.DTOs
{
    public class ScheduleDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int IdShift { get; set; }
        public string ChangedBy { get; set; }

        public DateTime Date { get; set; }

    }
}
