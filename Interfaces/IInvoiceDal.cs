using HealthClinic.DTOs;

namespace HealthClinic.Interfaces
{
    public interface IInvoiceDal
    {
        bool SaveInvoiceToDatabase(InvoiceDto invoiceDto);
    }
}
