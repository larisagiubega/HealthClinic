
namespace HealthClinic.Forms
{
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using HealthClinic.Presenters;
    using System;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;

    public partial class NoticeBoardForm : Form
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();
        private INoticePresenter noticePresenter;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        Form prevForm;
        public NoticeBoardForm(HealthClinicEntities ctx, Form prevForm)
        {
            InitializeComponent();

            _ctx = ctx;
            this.prevForm = prevForm;

            noticePresenter = new NoticePresenter(_ctx);
        }

        private void FillInNoticeBoard()
        {
            var notices = noticePresenter.GetAllNoticesFromLastWeek();

            rtbNotices.Text = string.Empty;

            rtbNotices.Text = noticePresenter.GetNoticesForTextboxFromList(notices);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void NoticeBoardForm_Load(object sender, EventArgs e)
        {
            ChangeControlsFont();

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelNoticeBoard);

            this.Text = res.GetString("HealthClinic");

            FillInNoticeBoard();
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelNoticeBoard.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }
    }
}
