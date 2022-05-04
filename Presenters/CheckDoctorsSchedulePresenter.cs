
namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System;
    using System.Collections.Generic;
    using System.Resources;
    public class CheckDoctorsSchedulePresenter : ICheckDoctorsSchedulePresenter
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private readonly IUserDal userDal;
        private readonly IScheduleDal scheduleDal;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();

        public CheckDoctorsSchedulePresenter(HealthClinicEntities ctx)
        {
            _ctx = ctx;

            userDal = new UserDal(_ctx);
            scheduleDal = new ScheduleDal(_ctx);
        }

        public List<string> GetAllDoctorsFullNames()
        {
            List<string> doctorsFullNames = new List<string>();

            var allDoctors = userDal.GetAllMedicalPersonnelAccounts();

            foreach (var doctor in allDoctors)
            {
                doctorsFullNames.Add(userDal.GetUserFullNameByUsername(doctor.Username));
            }

            return doctorsFullNames;
        }

        public UserDto GetUserByFullName(string fullName)
        {
            return userDal.GetUserByFullName(fullName);
        }

        public List<ScheduleDto> GetAllSchedulesForUserByUsername(string username)
        {
            return scheduleDal.GetAllSchedulesForUserByUsername(username);
        }

        public DateTime GetFirstDayOfFollowingWeek()
        {
            return scheduleDal.StartOfWeek(DateTime.Today.AddDays(7));
        }

        public string GetStartEndHourByShiftId(int shiftId)
        {
            return scheduleDal.GetStartEndHourByShiftId(shiftId);
        }
    }
}
