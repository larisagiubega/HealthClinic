

namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    public interface IAppointmentsDal
    {
        bool SaveAppointmentsToDb(List<AppointmentDto> appointments);
    }
}
