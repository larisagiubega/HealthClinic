
namespace HealthClinic.DTOs
{
    using System;
    public class ShiftDto
    {
        public int Id { get; set; }
        public string ShiftStart { get; set; }
        public string ShiftEnd { get; set; }

        //public DateTime DtShiftStart { get; set; }
        //public DateTime DtShiftEnd { get; set; }
    }
}
