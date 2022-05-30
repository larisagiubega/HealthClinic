
namespace HealthClinic.Forms__Views_
{
    using HealthClinic.DTOs;
    using HealthClinic.Forms;
    using HealthClinic.Forms__Views_.MedicalPersonnel;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using HealthClinic.Presenters;
    using System;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;
    public partial class MedicalPersonnelForm : Form
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        IMedicalPersonnelPresenter presenter;

        static UserDto loggedInUser = null;
        public MedicalPersonnelForm(HealthClinicEntities ctx, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            loggedInUser = user;

            presenter = new MedicalPersonnelPresenter(ctx);
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelMedicalPersonnel.Controls)
            {
                //control.Font = new Font(panelMedicalPersonnel.Font.FontFamily, 9, FontStyle.Regular);

                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void btnNoticeBoard_Click(object sender, EventArgs e)
        {
            NoticeBoardForm noticeBoardForm = new NoticeBoardForm(_ctx, this);
            noticeBoardForm.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(_ctx, this, loggedInUser);
            scheduleForm.Show();
            this.Hide();
        }

        private void MedicalPersonnelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loggedInUser = null;

            MainForm mainForm = new MainForm(_ctx);
            mainForm.Show();
            this.Hide();
        }

        private void MedicalPersonnelForm_Load(object sender, EventArgs e)
        {
            ChangeControlsFont();

            this.Text = $"{res.GetString("Welcome")}, {presenter.GetUserFullNameByUser(loggedInUser)}!";

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelMedicalPersonnel);
        }
    }
}
