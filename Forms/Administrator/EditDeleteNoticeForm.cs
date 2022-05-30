
namespace HealthClinic.Forms__Views_.Administrator
{
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using HealthClinic.Presenters;
    using System;
    using System.Collections.Generic;
    using System.Resources;
    using System.Windows.Forms;

    public partial class EditNoticeForm : Form
    {
        private HealthClinicEntities _ctx;

        private INoticePresenter noticePresenter;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        static UserDto loggedInUser = null;

        private Dictionary<int, NoticeBoardDto> noticesDict = new Dictionary<int, NoticeBoardDto>();

        Form prevForm;
        public EditNoticeForm(HealthClinicEntities ctx, Form prevForm, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            this.prevForm = prevForm;
            loggedInUser = user;

            noticePresenter = new NoticePresenter(_ctx, loggedInUser);
        }

        private void EditNoticeForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelEditNotice);

            rtbNotices.ReadOnly = true;
            btnShowAllNotices.Visible = false;

            HideButtons();
            FillInNoticeBoard();
            FillNoticesDropdown();
        }

        private void HideButtons()
        {
            btnEditNotice.Visible = false;
            btnDeleteNotice.Visible = false;
        }

        private void FillNoticesDropdown()
        {
            btnShowAllNotices.Visible = false;

            cbNotices.Items.Clear();

            cbNotices.Text = res.GetString("PleaseSelectNotice");

            int noticeNumber = 1;

            while (noticeNumber <= noticesDict.Count)
            {
                cbNotices.Items.Add($"{res.GetString("Notice")} {noticeNumber++}");
            }
        }

        private void FillInNoticeBoard()
        {
            rtbNotices.Text = string.Empty;

            noticesDict.Clear();

            int noticeNumber = 0;

            var notices = noticePresenter.GetAllNoticesFromLastWeek();

            foreach (var notice in notices)
            {
                noticesDict.Add(++noticeNumber, notice);
            }

            FillTextbox();

        }

        private void FillTextbox()
        {
            rtbNotices.Clear();

            btnShowAllNotices.Visible = false;

            rtbNotices.Text += noticePresenter.GetNoticesForTextboxFromDict(noticesDict);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void btnEditNotice_Click(object sender, EventArgs e)
        {
            var selectedNoticeNo = Convert.ToString(cbNotices.SelectedItem);

            if (string.IsNullOrEmpty(selectedNoticeNo))
            {
                MessageBox.Show(res.GetString("PleaseSelectNotice"), res.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var noticeNumber = GetNoticeNumberFromDropdown();

                var editedText = rtbNotices.Text.Trim();
                if (editedText.Equals(noticesDict[noticeNumber].Notice.Trim()))
                {
                    MessageBox.Show(res.GetString("PleaseEditNotice"), res.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var notice = noticesDict[noticeNumber];
                    NoticeBoardDto editedNotice = new NoticeBoardDto
                    {
                        Id = notice.Id,
                        AddedBy = loggedInUser.Username,
                        DateNotice = DateTime.Now,
                        Notice = Convert.ToString(rtbNotices.Text).Trim()
                    };

                    bool success = noticePresenter.EditNotice(notice.Id, editedNotice);

                    MessageBox.Show(noticePresenter.GetEditNoticeMessage(success), noticePresenter.GetEditNoticeTitle(success), MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (success)
                    {
                        noticesDict[noticeNumber] = editedNotice;

                        FillTextbox();
                        HideButtons();

                        cbNotices.Text = res.GetString("PleaseSelectNotice");
                    }
                }
            }
        }

        private void cbNotices_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedNotice = Convert.ToString(cbNotices.SelectedItem).Trim();

            if (selectedNotice.Equals(res.GetString("PleaseSelectNotice").Trim()))
            {
                rtbNotices.ReadOnly = true;
                btnShowAllNotices.Visible = false;
                FillTextbox();
                HideButtons();
            }
            else
            {
                btnShowAllNotices.Visible = true;
                int noticeNumber = GetNoticeNumberFromDropdown();

                FillNoticeBoardWithNoticeNumber(noticeNumber);
            }
        }

        private int GetNoticeNumberFromDropdown()
        {
            var selectedNotice = Convert.ToString(cbNotices.SelectedItem).Trim();
            return Convert.ToInt32(selectedNotice.Split(' ')[1]);
        }

        private void FillNoticeBoardWithNoticeNumber(int noticeNumber)
        {
            rtbNotices.Clear();

            var notice = noticesDict[noticeNumber];

            rtbNotices.Text = notice.Notice;

            rtbNotices.ReadOnly = false;

            ShowButtons();
        }

        private void ShowButtons()
        {
            btnEditNotice.Visible = true;
            btnDeleteNotice.Visible = true;
        }

        private void btnShowAllNotices_Click(object sender, EventArgs e)
        {
            cbNotices.Text = res.GetString("PleaseSelectNotice");
            rtbNotices.ReadOnly = true;
            FillTextbox();
            HideButtons();
        }

        private void btnDeleteNotice_Click(object sender, EventArgs e)
        {
            var noticeNumber = GetNoticeNumberFromDropdown();
            var noticeId = noticesDict[noticeNumber].Id;

            bool success = noticePresenter.DeleteNoticeById(noticeId);

            MessageBox.Show(noticePresenter.GetDeleteNoticeMessage(success), noticePresenter.GetDeleteNoticeTitle(success), MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (success)
            {
                FillInNoticeBoard();
                FillNoticesDropdown();
                HideButtons();

                cbNotices.Text = res.GetString("PleaseSelectNotice");
            }
        }
    }
}
