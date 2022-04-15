
namespace HealthClinic.DTOs
{
    using System;
    public class MedicineDto
    {
        public int Id { get; set; }
        public string MedicineName { get; set; }
        public int Quantity { get; set; }
        public DateTime LastBilling { get; set; }
    }
}
