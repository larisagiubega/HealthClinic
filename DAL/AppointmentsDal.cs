namespace HealthClinic.DAL
{
    using HealthClinic.DTOs;
    using HealthClinic.Exceptions;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Resources;

    public class AppointmentsDal : IAppointmentsDal
    {
        HealthClinicEntities _ctx;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();

        public AppointmentsDal(HealthClinicEntities ctx)
        {
            _ctx = ctx;
        }
        public bool SaveAppointmentsToDb(List<AppointmentDto> appointments)
        {
            bool success = false;

            try
            {
                List<APPOINTMENTS> appointmentsDb = appointments.Select(x => new APPOINTMENTS
                {
                    FIRST_NAME = x.FirstName,
                    LAST_NAME = x.LastName,
                    APPOINTMENT_DATE = x.Date,
                    DOCTOR_USERNAME = x.Doctor.Username,
                    PHONE_NUMBER = x.PhoneNumber
                }).ToList();

                _ctx.APPOINTMENTS.AddRange(appointmentsDb);
                _ctx.SaveChanges();

                success = true;
            }
            catch
            {
                Logger.Log(res.GetString(new SaveAppointmentsException().Message));
                success = false;
            }

            return success;
        }
        public List<AppointmentDto> GetAppointmentsForUserByUsernameAndDay(string username, DateTime day)
        {
            List<AppointmentDto> allAppointmentsForToday = new List<AppointmentDto>();

            DateTime nextDay = day.AddDays(1);

            try
            {
                allAppointmentsForToday = _ctx.APPOINTMENTS.Where(x => x.APPOINTMENT_DATE >= day.Date && x.APPOINTMENT_DATE < nextDay && x.DOCTOR_USERNAME.Trim().ToLower().Equals(username.Trim().ToLower())).Select(y => new AppointmentDto
                {
                    FirstName = y.FIRST_NAME,
                    LastName = y.LAST_NAME,
                    PhoneNumber = y.PHONE_NUMBER,
                    Date = y.APPOINTMENT_DATE,
                    Doctor = new UserDto
                    {
                        Username = username
                    }
                }).ToList();
            }
            catch
            {
                Logger.Log(res.GetString(new GetAppointmentsForUserException().Message));
            }

            return allAppointmentsForToday;
        }
    }
}
