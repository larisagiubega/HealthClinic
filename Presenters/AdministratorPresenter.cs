namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using System.Collections.Generic;
    public class AdministratorPresenter : IAdministratorPresenter
    {
        private readonly IAppointmentsDal appointmentsDal;
        private readonly IMedicineDal medicineDal;
        private readonly IInvoiceDal invoiceDal;

        public AdministratorPresenter(HealthClinicEntities ctx)
        {
            appointmentsDal = new AppointmentsDal(ctx);
            medicineDal = new MedicineDal(ctx);
            invoiceDal = new InvoiceDal(ctx);
        }

        public bool SaveAppointmentsToDb(List<AppointmentDto> appointments)
        {
            return appointmentsDal.SaveAppointmentsToDb(appointments);
        }

        public bool SaveInvoiceToDatabase(InvoiceDto invoiceDto)
        {
            return invoiceDal.SaveInvoiceToDatabase(invoiceDto);
        }

        public bool SaveMedicineToDatabase(MedicineDto medicine)
        {
            return medicineDal.SaveMedicineToDatabase(medicine);
        }
    }
}
