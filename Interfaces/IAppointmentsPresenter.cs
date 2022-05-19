
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System;
    using System.Collections.Generic;

    public interface IAppointmentsPresenter
    {
        bool IsDateCorrect(string day, string month, string year, string hour, out DateTime date);
        bool IsNameCorrect(string name);
        bool IsPhoneNumberCorrect(string phoneNo);
        bool IsDoctorAvailable(string username, DateTime appointmentDate);
        DateTime RoundTime(DateTime dateTime);
        List<UserDto> GetAllDoctors();
        UserDto GetDoctorByFullName(string fullName);
    }
}
