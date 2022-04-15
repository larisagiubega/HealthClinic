
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    interface INoticeBoardDal
    {
        List<NoticeBoardDto> GetAllNotices();
        List<NoticeBoardDto> GetAllNoticesFromLastWeek();
        bool AddNotice(NoticeBoardDto notice);
        bool EditNotice(int noticeId, NoticeBoardDto editedNotice);
        bool DeleteNoticeById(int noticeId);

    }
}
