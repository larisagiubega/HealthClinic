
namespace HealthClinic.DTOs
{
    using System;
    public class NoticeBoardDto
    {
        public int Id { get; set; }
        public string Notice { get; set; }
        public DateTime DateNotice { get; set; }
        public string AddedBy { get; set; }
    }
}
