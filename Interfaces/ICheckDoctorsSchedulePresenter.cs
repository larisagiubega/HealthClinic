using HealthClinic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Interfaces
{
    public interface ICheckDoctorsSchedulePresenter
    {
        List<string> GetAllDoctorsFullNames();
        UserDto GetUserByFullName(string fullName);

        List<ScheduleDto> GetAllSchedulesForUserByUsername(string username);
        DateTime GetFirstDayOfFollowingWeek();

        string GetStartEndHourByShiftId(int shiftId);
    }
}
