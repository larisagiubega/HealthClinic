
namespace HealthClinic.Forms.Administrator
{
    using HealthClinic.Presenters;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;
    using HealthClinic.DTOs;
    public partial class CreateNoticeForm : Form
    {
        private INoticePresenter noticePresenter;

        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        static UserDto loggedInUser = null;

        Form prevForm;

        public CreateNoticeForm(HealthClinicEntities ctx, Form prevForm, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            loggedInUser = user;

            noticePresenter = new NoticePresenter(_ctx, loggedInUser);

            this.prevForm = prevForm;
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelCreateNotice.Controls)
            {
                //control.Font = new Font(panelCreateNotice.Font.FontFamily, 9, FontStyle.Regular);

                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void btnDeleteNotice_Click(object sender, EventArgs e)
        {
            tbNotice.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NoticeBoardDto notice = new NoticeBoardDto
            {
                AddedBy = loggedInUser.Username,
                DateNotice = DateTime.Now,
                Notice = tbNotice.Text
            };

            bool success = noticePresenter.AddNotice(notice);

            MessageBox.Show(noticePresenter.GetAddNoticeMessage(success), noticePresenter.GetAddNoticeTitle(success), MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (!success)
                tbNotice.Text = string.Empty;
        }

        private void CreateNoticeForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");
            ChangeControlsFont();

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelCreateNotice);
        }
    }
}
