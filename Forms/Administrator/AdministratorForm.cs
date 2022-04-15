﻿
namespace HealthClinic.Forms__Views_
{
    using HealthClinic.Forms;
    using HealthClinic.Forms.Administrator;
    using HealthClinic.Forms__Views_.Administrator;
    using System;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;
    using HealthClinic.Localization;
    using HealthClinic.DTOs;

    public partial class AdministratorForm : Form
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        static UserDto loggedInUser = null;
        public AdministratorForm(HealthClinicEntities ctx, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            loggedInUser = user;
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelAdmin.Controls)
            {
                //control.Font = new Font(panelAdmin.Font.FontFamily, 9, FontStyle.Regular);

                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void btnNoticeBoard_Click(object sender, EventArgs e)
        {
            NoticeBoardForm noticeBoardForm = new NoticeBoardForm(_ctx, this);
            noticeBoardForm.Show();
            this.Hide();
        }

        private void btnCreateSchedule_Click(object sender, EventArgs e)
        {
            CreateScheduleForm scheduleForm = new CreateScheduleForm(_ctx, this, loggedInUser);
            scheduleForm.Show();
            this.Hide();
        }

        private void btnValidateAppointments_Click(object sender, EventArgs e)
        {
            var appointments = UseExcel.GetAppointmentsFromExcel();
            //ValidateAppointmentsForm appointmentsForm = new ValidateAppointmentsForm(_ctx, this, loggedInUser);
            //appointmentsForm.Show();
            //this.Hide();
        }

        private void btnProcessInvoices_Click(object sender, EventArgs e)
        {
            ProcessInvoices invoicesForm = new ProcessInvoices(_ctx, this, loggedInUser);
            invoicesForm.Show();
            this.Hide();
        }

        private void btnMedications_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            loggedInUser = null;

            MainForm mainForm = new MainForm(_ctx);
            mainForm.Show();
            this.Hide();
        }

        private void btnCreateNotice_Click(object sender, EventArgs e)
        {
            CreateNoticeForm createNotice = new CreateNoticeForm(_ctx, this, loggedInUser);
            createNotice.Show();
            this.Hide();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            ChangeControlsFont();

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelAdmin);
        }

        private void btnEditNotice_Click(object sender, EventArgs e)
        {
            EditNoticeForm editNotice = new EditNoticeForm(_ctx, this, loggedInUser);
            editNotice.Show();
            this.Hide();
        }

        private void btnDeleteNotice_Click(object sender, EventArgs e)
        {

        }
    }
}
