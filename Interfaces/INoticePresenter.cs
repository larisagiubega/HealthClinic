
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    public interface INoticePresenter
    {
        bool AddNotice(NoticeBoardDto notice);
        bool EditNotice(int noticeId, NoticeBoardDto editedNotice);
        bool DeleteNoticeById(int noticeId);
        string GetAddNoticeTitle(bool success);
        string GetEditNoticeTitle(bool success);
        string GetDeleteNoticeTitle(bool success);
        string GetAddNoticeMessage(bool success);
        string GetEditNoticeMessage(bool success);
        string GetDeleteNoticeMessage(bool success);
        string GetNoticesForTextboxFromDict(Dictionary<int, NoticeBoardDto> dict);
        string GetNoticesForTextboxFromList(List<NoticeBoardDto> notices);
        List<NoticeBoardDto> GetAllNoticesFromLastWeek();
    }
}
