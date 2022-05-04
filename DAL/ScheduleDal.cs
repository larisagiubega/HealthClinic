
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

    class ScheduleDal : IScheduleDal
    {
        HealthClinicEntities _ctx;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        public ScheduleDal(HealthClinicEntities ctx)
        {
            _ctx = ctx;
        }

        public bool AddSchedule(ScheduleDto scheduleDto)
        {
            bool success = false;

            try
            {
                var schedule = new SCHEDULE
                {
                    CHANGED_BY = scheduleDto.ChangedBy,
                    DATE = scheduleDto.Date,
                    USERNAME = scheduleDto.Username,
                    ID_SHIFT = scheduleDto.IdShift
                };

                _ctx.SCHEDULE.Add(schedule);
                _ctx.SaveChanges();

                success = true;
            }
            catch
            {
                Logger.Log(res.GetString(new AddScheduleException().Message));
            }

            return success;

        }

        public bool ExistsSchedule(ScheduleDto scheduleDto)
        {
            try
            {
                //a person cannot work multiple shifts the same day
                return _ctx.SCHEDULE.Any(x => x.DATE == scheduleDto.Date && x.USERNAME.Equals(scheduleDto.Username));
            }
            catch
            {
                Logger.Log(res.GetString(new CannotGetSchedule().Message));
                return false;
            }
        }

        public List<ShiftDto> GetAllShiftHours()
        {
            try
            {
                var allShifts = _ctx.SHIFT.Select(x => new ShiftDto
                {
                    Id = x.ID_SHIFT,
                    ShiftStart = x.SHIFT_START,
                    ShiftEnd = x.SHIFT_END
                }).ToList();

                return allShifts;
            }
            catch
            {
                Logger.Log(res.GetString(new GetAllShiftsException().Message));
                return new List<ShiftDto>();
            }
        }

        public List<ScheduleDto> GetAllSchedulesForUserByUsername(string username)
        {
            try
            {
                var allShifts = _ctx.SCHEDULE.Where(x => x.USERNAME.ToLower().Equals(username.ToLower())).Select(y => new ScheduleDto
                {
                    Id = y.ID_SCHEDULE,
                    IdShift = y.ID_SHIFT,
                    ChangedBy = y.CHANGED_BY,
                    Date = y.DATE,
                    Username = y.USERNAME
                }).OrderBy(z => z.Date).ToList();

                return allShifts;
            }
            catch
            {
                Logger.Log(res.GetString(new GetAllShiftsForUserException().Message));
                return new List<ScheduleDto>();
            }
        }

        public int GetShiftIdByStartAndEndHour(string startHour, string endHour)
        {
            int shiftId = -1;

            try
            {
                shiftId = _ctx.SHIFT.FirstOrDefault(x => x.SHIFT_START.Equals(startHour) && x.SHIFT_END.Equals(endHour)).ID_SHIFT;
            }
            catch
            {
                Logger.Log(res.GetString(new GetShiftByHoursException().Message));
            }

            return shiftId;
        }

        public string GetStartEndHourByShiftId(int shiftId)
        {
            string startEndHour = "";

            try
            {
                var shift = _ctx.SHIFT.Where(x => x.ID_SHIFT == shiftId).Select(y => new ShiftDto
                {
                    ShiftStart = y.SHIFT_START,
                    ShiftEnd = y.SHIFT_END
                }).FirstOrDefault();

                startEndHour = $"{shift.ShiftStart} - {shift.ShiftEnd}";
            }
            catch
            {
                Logger.Log(res.GetString(new GetHoursException().Message));
            }

            return startEndHour;
        }

        public DateTime StartOfWeek(DateTime today)
        {
            return today.AddDays(-(int)today.DayOfWeek).AddDays(1); //add 1 day because of ISO
        }
    }
}
