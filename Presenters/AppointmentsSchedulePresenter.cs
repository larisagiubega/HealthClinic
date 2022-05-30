namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using System;
    using System.Collections.Generic;
    public class AppointmentsSchedulePresenter : IAppointmentsSchedulePresenter
    {
        private readonly IScheduleDal scheduleDal;
        private readonly IAppointmentsDal appointmentsDal;
        public AppointmentsSchedulePresenter(HealthClinicEntities ctx)
        {
            scheduleDal = new ScheduleDal(ctx);
            appointmentsDal = new AppointmentsDal(ctx);
        }

        public List<AppointmentDto> GetAppointmentsForUserByUsernameAndDay(string username, DateTime day)
        {
            return appointmentsDal.GetAppointmentsForUserByUsernameAndDay(username, day);
        }

        public DateTime StartOfWeek(DateTime today)
        {
            return scheduleDal.StartOfWeek(today);
        }
    }
}
