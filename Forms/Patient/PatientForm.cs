using HealthClinic.Forms.Patient;
using HealthClinic.Forms__Views_;
using HealthClinic.Forms__Views_.Patient;
using HealthClinic.Localization;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace HealthClinic.Forms
{
    public partial class PatientForm : Form
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();
        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        private Form prevForm;
        public PatientForm(HealthClinicEntities ctx, Form prevForm)
        {
            InitializeComponent();

            _ctx = ctx;
            this.prevForm = prevForm;
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelPatient.Controls)
            {
                //control.Font = new Font(panelPatient.Font.FontFamily, 9, FontStyle.Regular);

                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void btnNoticeBoard_Click(object sender, EventArgs e)
        {
            NoticeBoardForm noticeBoardForm = new NoticeBoardForm(_ctx, this);
            noticeBoardForm.Show();
            this.Hide();
        }

        private void btnCheckSymptoms_Click(object sender, EventArgs e)
        {
            CheckSymptomsForm checkSymptomsForm = new CheckSymptomsForm(_ctx, this);
            checkSymptomsForm.Show();
            this.Hide();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm checkSymptomsForm = new AppointmentsForm(_ctx, this);
            checkSymptomsForm.Show();
            this.Hide();
        }

        private void PatientForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            prevForm.Show();
            this.Hide();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            this.Text = $"{res.GetString("WelcomePatient")}";

            ChangeControlsFont();
            HealthClinicLocalization.FillControlsByLanguage(res, language, panelPatient);
        }

        private void btnCheckSchedules_Click(object sender, EventArgs e)
        {
            CheckDoctorsSchedule checkDoctorsSchedule = new CheckDoctorsSchedule(_ctx, this);
            checkDoctorsSchedule.Show();
            this.Hide();
        }
    }
}
