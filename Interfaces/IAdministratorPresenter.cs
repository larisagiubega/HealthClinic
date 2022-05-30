namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    public interface IAdministratorPresenter
    {
        bool SaveAppointmentsToDb(List<AppointmentDto> appointments);
        bool SaveMedicineToDatabase(MedicineDto medicine);
        bool SaveInvoiceToDatabase(InvoiceDto invoiceDto);
    }
}
