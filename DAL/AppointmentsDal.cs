

namespace HealthClinic.DAL
{
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppointmentsDal : IAppointmentsDal
    {
        HealthClinicEntities _ctx;
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
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
                success = false;
            }

            return success;
        }
    }
}
