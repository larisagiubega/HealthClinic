
namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Enums;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Resources;

    public class SchedulePresenter : ISchedulePresenter
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        private readonly IUserDal userDal;
        private readonly IScheduleDal scheduleDal;
        public SchedulePresenter(HealthClinicEntities ctx)
        {
            _ctx = ctx;

            userDal = new UserDal(_ctx);
            scheduleDal = new ScheduleDal(_ctx);
        }

        public List<ShiftDto> GetAllShiftHours()
        {
            return scheduleDal.GetAllShiftHours();
        }

        public string[] GetDaysOfWeek()
        {
            var daysOfWeek = Enum.GetNames(typeof(HealthClinicEnums.DaysOfWeek)).ToArray();

            daysOfWeek = daysOfWeek.Select(x => res.GetString(x)).ToArray();

            return daysOfWeek;
        }

        public List<UserDto> GetAllMedicalPersonnelAccounts()
        {
            return userDal.GetAllMedicalPersonnelAccounts();
        }

        public string[] GetAllMedicalPersonnelFullNames()
        {
            var allMedicalPersonnel = GetAllMedicalPersonnelAccounts();

            var medicalPersonnelFullNames = allMedicalPersonnel.Select(x => userDal.GetUserFullNameByUser(x)).ToArray();

            return medicalPersonnelFullNames;
        }

        public UserDto GetUserByFullName(string fullName)
        {
            return userDal.GetUserByFullName(fullName);
        }

        public DateTime GetFirstDayOfFollowingWeek()
        {
            return scheduleDal.StartOfWeek(DateTime.Today.AddDays(7));
        }

        public int GetShiftIdByStartAndEndHour(string startHour, string endHour)
        {
            return scheduleDal.GetShiftIdByStartAndEndHour(startHour, endHour);
        }

        public bool ExistsSchedule(ScheduleDto schedule)
        {
            return scheduleDal.ExistsSchedule(schedule);
        }

        public bool AddSchedule(ScheduleDto schedule)
        {
            return scheduleDal.AddSchedule(schedule);
        }
    }
}
