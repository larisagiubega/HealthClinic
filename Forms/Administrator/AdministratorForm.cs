using HealthClinic.Forms;
using HealthClinic.Forms.Administrator;
using HealthClinic.Forms__Views_.Administrator;
using System;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using HealthClinic.Localization;
using HealthClinic.DTOs;
using HealthClinic.Interfaces;
using HealthClinic.Exceptions;
using HealthClinic.Presenters;

namespace HealthClinic.Forms__Views_
{
    public partial class AdministratorForm : Form
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        IAdministratorPresenter presenter;

        static UserDto loggedInUser = null;
        public AdministratorForm(HealthClinicEntities ctx, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            loggedInUser = user;

            presenter = new AdministratorPresenter(_ctx);
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelAdmin.Controls)
            {
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

            if (appointments.Count == 0)
            {
                MessageBox.Show(res.GetString("NoAppointmentsInExcel"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (presenter.SaveAppointmentsToDb(appointments))
                {
                    MessageBox.Show(res.GetString("AppointmentsSaved"), res.GetString("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(res.GetString("AppointmentsCouldNotBeSaved"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProcessInvoices_Click(object sender, EventArgs e)
        {
            bool success = true;
            try
            {
                var invoices = UsePDF.GetValidatedInvoices(loggedInUser.Username);

                if (invoices.Count > 0)
                {
                    foreach (var invoice in invoices)
                    {
                        success = success && SaveInvoiceAndMedicineToDatabase(invoice);
                    }

                    if(success)
                    {
                        MessageBox.Show(res.GetString("InvoicesSaved"), res.GetString("Success"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show(res.GetString("NoInvoices"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.Log(res.GetString(new CannotProcessInvoicesException().Message));
            }
        }

        public bool SaveInvoiceAndMedicineToDatabase(InvoiceDto invoice)
        {
            bool success = true;

            var medicineList = invoice.MedicineList;

            foreach (var medicine in medicineList)
            {
                success = success && presenter.SaveMedicineToDatabase(medicine);
            }

            success = success && presenter.SaveInvoiceToDatabase(invoice);

            return success;
        }

        private void btnMedications_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm(_ctx, this, loggedInUser);
            medicineForm.Show();
            this.Hide();
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
    }
}
