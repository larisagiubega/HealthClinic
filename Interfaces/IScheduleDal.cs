
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System;
    using System.Collections.Generic;
    interface IScheduleDal
    {
        bool AddSchedule(ScheduleDto scheduleDto);

        bool ExistsSchedule(ScheduleDto scheduleDto);
        bool IsDoctorAvailable(string username, DateTime appointmentDate);
        List<ShiftDto> GetAllShiftHours();

        List<ScheduleDto> GetAllSchedulesForUserByUsername(string username);

        int GetShiftIdByStartAndEndHour(string startHour, string endHour);

        int GetShiftIdByHour(DateTime appointmentDate);

        string GetStartEndHourByShiftId(int shiftId);

        DateTime StartOfWeek(DateTime today);

    }
}
