
namespace HealthClinic.DTOs
{
    using System;
    public class InvoiceDto
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
