
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System;
    using System.Collections.Generic;
    public interface ISchedulePresenter
    {
        List<ShiftDto> GetAllShiftHours();
        string[] GetDaysOfWeek();
        string[] GetAllMedicalPersonnelFullNames();
        List<UserDto> GetAllMedicalPersonnelAccounts();

        UserDto GetUserByFullName(string fullName);

        DateTime GetFirstDayOfFollowingWeek();
        int GetShiftIdByStartAndEndHour(string startHour, string endHour);

        bool ExistsSchedule(ScheduleDto schedule);
        bool AddSchedule(ScheduleDto schedule);
    }
}
