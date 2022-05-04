

namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System;
    using System.Collections.Generic;
    public interface IAppointmentsDal
    {
        bool SaveAppointmentsToDb(List<AppointmentDto> appointments);
        List<AppointmentDto> GetAppointmentsForUserByUsernameAndDay(string username, DateTime day);
    }
}
