
namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Exceptions;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System.Collections.Generic;
    using System.Resources;
    public class NoticePresenter : INoticePresenter
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private readonly INoticeBoardDal noticeBoardDal;
        private readonly IUserDal userDal;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();

        private static UserDto loggedInUser = null;

        public NoticePresenter(HealthClinicEntities ctx, UserDto user = null)
        {
            _ctx = ctx;
            loggedInUser = user;

            noticeBoardDal = new NoticeBoardDal(_ctx);
            userDal = new UserDal(_ctx);
        }

        public bool AddNotice(NoticeBoardDto notice)
        {
            bool success = noticeBoardDal.AddNotice(notice);

            return success;
        }

        public string GetAddNoticeTitle(bool success)
        {
            return success ? "" : res.GetString("SomethingWentWrong");
        }

        public string GetAddNoticeMessage(bool success)
        {
            return success ? res.GetString("SuccessfullySaved") : res.GetString("AddingNoticeUnsuccessful");
        }

        public List<NoticeBoardDto> GetAllNoticesFromLastWeek()
        {
            return noticeBoardDal.GetAllNoticesFromLastWeek();
        }

        public string GetNoticesForTextboxFromDict(Dictionary<int, NoticeBoardDto> dict)
        {
            string textToWrite = "";

            foreach (var elm in dict)
            {
                var addedBy = userDal.GetUserFullNameByUsername(elm.Value.AddedBy);

                textToWrite += $"{res.GetString("Notice")} {elm.Key} \n {elm.Value.Notice} \n \t\t {res.GetString("CreatedBy")} {addedBy} ({elm.Value.DateNotice})";
                textToWrite += "\n\n\n\n\n";
            }

            return textToWrite;

        }

        public bool EditNotice(int noticeId, NoticeBoardDto editedNotice)
        {
            return noticeBoardDal.EditNotice(noticeId, editedNotice);
        }

        public string GetEditNoticeTitle(bool success)
        {
            return success ? "" : res.GetString("SomethingWentWrong");
        }

        public string GetEditNoticeMessage(bool success)
        {
            return success ? res.GetString("SuccessfullyEdited") : res.GetString("EditingNoticeUnsuccessful");
        }

        public bool DeleteNoticeById(int noticeId)
        {
            return noticeBoardDal.DeleteNoticeById(noticeId);
        }

        public string GetDeleteNoticeTitle(bool success)
        {
            return success ? "" : res.GetString("SomethingWentWrong");
        }

        public string GetDeleteNoticeMessage(bool success)
        {
            return success ? res.GetString("SuccessfullyDeleted") : res.GetString("DeletingNoticeUnsuccessful");
        }

        public string GetNoticesForTextboxFromList(List<NoticeBoardDto> notices)
        {
            string textToWrite = "";

            foreach (var notice in notices)
            {
                var addedBy = userDal.GetUserFullNameByUsername(notice.AddedBy);

                textToWrite += $"{notice.Notice} \n \t\t {res.GetString("CreatedBy")} {addedBy} ({notice.DateNotice})";
                textToWrite += "\n\n\n\n\n";
            }

            return textToWrite;
        }
    }
}
