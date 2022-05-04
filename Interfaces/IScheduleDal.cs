
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System;
    using System.Collections.Generic;
    interface IScheduleDal
    {
        bool AddSchedule(ScheduleDto scheduleDto);

        bool ExistsSchedule(ScheduleDto scheduleDto);
        List<ShiftDto> GetAllShiftHours();

        List<ScheduleDto> GetAllSchedulesForUserByUsername(string username);

        int GetShiftIdByStartAndEndHour(string startHour, string endHour);

        string GetStartEndHourByShiftId(int shiftId);

        DateTime StartOfWeek(DateTime today);

    }
}
