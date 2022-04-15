

namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Resources;

    public class AppointmentsPresenter : IAppointmentsPresenter
    {
        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private readonly IUserDal userDal;

        public AppointmentsPresenter(HealthClinicEntities ctx)
        {
            _ctx = ctx;

            userDal = new UserDal(_ctx);
        }

        public bool IsDateCorrect(string day, string month, string year, string hour, out DateTime date)
        {
            string dateString = $"{day}.{month}.{year} {hour}";

            bool isDateCorrect = DateTime.TryParse(dateString, out date);

            if (isDateCorrect && date >= DateTime.Now.AddDays(1))
            {
                isDateCorrect = true;
            }
            else
            {
                isDateCorrect = false;
            }

            return isDateCorrect;
        }

        public List<UserDto> GetAllDoctors()
        {
            return userDal.GetAllMedicalPersonnelAccounts();
        }

        public UserDto GetDoctorByFullName(string fullName)
        {
            return userDal.GetUserByFullName(fullName);
        }

        public bool IsNameCorrect(string name)
        {
            return !name.Any(char.IsDigit);
        }

        public bool IsPhoneNumberCorrect(string phoneNo)
        {
            return !phoneNo.Any(char.IsLetter);
        }
    }
}
