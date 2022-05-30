namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System;
    using System.Collections.Generic;
    public interface IAppointmentsSchedulePresenter
    {
        DateTime StartOfWeek(DateTime today);
        List<AppointmentDto> GetAppointmentsForUserByUsernameAndDay(string username, DateTime day);
    }
}
