
namespace HealthClinic.DTOs
{
    using System;
    using System.Collections.Generic;

    public class InvoiceDto
    {
        public int Id { get; set; }
        public string SupplierName { get; set; }
        public string ValidatedBy { get; set; }
        public DateTime BillingDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string InvoiceNumber { get; set; }

        public List<MedicineDto> MedicineList{ get; set; }
    }
}
