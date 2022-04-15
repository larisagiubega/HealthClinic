using HealthClinic.DTOs;
using HealthClinic.Exceptions;
using HealthClinic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HealthClinic.DAL
{
    public class NoticeBoardDal : INoticeBoardDal
    {
        HealthClinicEntities _ctx;
        public NoticeBoardDal(HealthClinicEntities ctx)
        {
            _ctx = ctx;
        }

        public bool AddNotice(NoticeBoardDto noticeDto)
        {
            bool success = false;

            try
            {
                var notice = new NOTICE_BOARD
                {
                    DATE_NOTICE = noticeDto.DateNotice,
                    ADDED_BY = noticeDto.AddedBy,
                    NOTICE = noticeDto.Notice
                };

                _ctx.NOTICE_BOARD.Add(notice);
                _ctx.SaveChanges();
                success = true;
            }
            catch
            {
                Logger.Log("Exception");
            }

            return success;
        }

        public bool DeleteNoticeById(int noticeId)
        {
            bool success = false;
            try
            {
                var noticeToDelete = _ctx.NOTICE_BOARD.FirstOrDefault(x => x.ID_NOTICE == noticeId);

                _ctx.NOTICE_BOARD.Remove(noticeToDelete);
                _ctx.SaveChanges();
                success = true;
            }
            catch
            {
                Logger.Log("Exception");
            }

            return success;
        }

        public bool EditNotice(int noticeId, NoticeBoardDto editedNotice)
        {
            bool success = false;
            try
            {
                var noticeToBeEdited = _ctx.NOTICE_BOARD.FirstOrDefault(x => x.ID_NOTICE == noticeId);

                noticeToBeEdited.ADDED_BY = editedNotice.AddedBy;
                noticeToBeEdited.DATE_NOTICE = editedNotice.DateNotice;
                noticeToBeEdited.NOTICE = editedNotice.Notice;

                _ctx.SaveChanges();
                success = true;
            }
            catch
            {
                Logger.Log("Exception");
            }
            return success;
        }

        public List<NoticeBoardDto> GetAllNotices()
        {
            try
            {
                var notices = _ctx.NOTICE_BOARD.Select(x => new NoticeBoardDto
                {
                    Id = x.ID_NOTICE,
                    Notice = x.NOTICE,
                    AddedBy = x.ADDED_BY,
                    DateNotice = x.DATE_NOTICE
                }).ToList();

                return notices;
            }
            catch
            {
                Logger.Log("Exception");
                return new List<NoticeBoardDto>();
            }
        }

        public List<NoticeBoardDto> GetAllNoticesFromLastWeek()
        {
            try
            {
                var allNotices = GetAllNotices();

                var allNoticesFromLastWeek = allNotices.Where(x => x.DateNotice >= System.DateTime.Today.AddDays(-7)).ToList();

                return allNoticesFromLastWeek;
            }
            catch
            {
                Logger.Log("Exception");
                return new List<NoticeBoardDto>();
            }
        }
    }
}
