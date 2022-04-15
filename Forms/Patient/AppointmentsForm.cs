﻿
namespace HealthClinic.Forms__Views_.Patient
{
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using HealthClinic.Presenters;
    using System;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;
    public partial class AppointmentsForm : Form
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();
        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        IAppointmentsPresenter presenter;

        Form prevForm;

        public AppointmentsForm(HealthClinicEntities ctx, Form prevForm)
        {
            InitializeComponent();

            presenter = new AppointmentsPresenter(ctx);

            _ctx = ctx;
            this.prevForm = prevForm;
        }

        private void AppointmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelAppointments);
            HealthClinicLocalization.FillControlsByLanguage(res, language, panelCardAppointments);

            FillDateComboboxes();

            ChangeControlsFont();
        }

        private void FillDateComboboxes()
        {
            FillDayCombobox();
            FillMonthCombobox();
            FillYearCombobox();

            FillHourCombobox();

            FillDoctorCombobox();
        }

        private void FillDoctorCombobox()
        {
            if (cbDoctor.Items.Count == 0)
            {
                var doctors = presenter.GetAllDoctors();

                foreach (var doctor in doctors)
                {
                    cbDoctor.Items.Add($"{doctor.FirstName} {doctor.LastName}");
                }
            }
        }

        private void FillHourCombobox()
        {
            if (cbAppointmentHour.Items.Count == 0)
            {
                var eightAm = DateTime.Today.AddHours(8);
                var ninePm = DateTime.Today.AddHours(21);

                DateTime currentHour = eightAm;
                string currentHourString;

                while (currentHour <= ninePm)
                {
                    currentHourString = currentHour.ToString("HH:mm");
                    cbAppointmentHour.Items.Add(currentHourString);

                    currentHour = currentHour.AddMinutes(30);
                }
            }
        }

        private void FillYearCombobox()
        {
            if (cbYear.Items.Count == 0)
            {
                cbYear.Items.Add(DateTime.Now.Year);
                cbYear.Items.Add(DateTime.Now.Year + 1);
            }
        }

        private void FillMonthCombobox()
        {
            if (cbMonth.Items.Count == 0)
            {
                for (int i = 1; i <= 12; i++)
                {
                    cbMonth.Items.Add(i);
                }
            }
        }

        private void FillDayCombobox()
        {
            if (cbDay.Items.Count == 0)
            {
                for (int i = 1; i <= 31; i++)
                {
                    cbDay.Items.Add(i);
                }
            }
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelAppointments.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
            foreach (Control control in panelCardAppointments.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text))
            {
                MessageBox.Show(res.GetString("PleaseInsertFirstName"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (string.IsNullOrEmpty(tbLastName.Text))
            {
                MessageBox.Show(res.GetString("PleaseInsertLastName"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (string.IsNullOrEmpty(tbPhoneNumber.Text))
            {
                MessageBox.Show(res.GetString("PleaseInsertPhoneNumber"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (cbDay.SelectedItem == null || cbMonth.SelectedItem == null || cbYear.SelectedItem == null)
            {
                MessageBox.Show(res.GetString("PleasePickAValidDate"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (cbDoctor.SelectedItem == null)
            {
                MessageBox.Show(res.GetString("PleasePickADoctor"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var isDateCorrect = presenter.IsDateCorrect(Convert.ToString(cbDay.SelectedItem), Convert.ToString(cbMonth.SelectedItem),
                    Convert.ToString(cbYear.SelectedItem), Convert.ToString(cbAppointmentHour.SelectedItem), out DateTime date);
                var isFirstNameCorrect = presenter.IsNameCorrect(tbFirstName.Text);
                var isLastNameCorrect = presenter.IsNameCorrect(tbLastName.Text);
                var isPhoneNumberCorrect = presenter.IsPhoneNumberCorrect(tbPhoneNumber.Text);

                if (isDateCorrect && isFirstNameCorrect && isLastNameCorrect && isPhoneNumberCorrect)
                {
                    AppointmentDto appointment = new AppointmentDto
                    {
                        FirstName = tbFirstName.Text,
                        LastName = tbLastName.Text,
                        Date = date,
                        Doctor = presenter.GetDoctorByFullName(Convert.ToString(cbDoctor.SelectedItem)),
                        PhoneNumber = tbPhoneNumber.Text
                    };

                    if (UseExcel.SaveAppointmentToExcel(appointment))
                    {
                        MessageBox.Show(res.GetString("AppointmentSaved"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(res.GetString("ErrorSavingAppointment"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (!isDateCorrect)
                    {
                        MessageBox.Show(res.GetString("PleasePickAValidDate"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    if (!isFirstNameCorrect)
                    {
                        MessageBox.Show(res.GetString("PleaseInsertAValidFirstName"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    if (!isLastNameCorrect)
                    {
                        MessageBox.Show(res.GetString("PleaseInsertAValidLastName"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    if (!isPhoneNumberCorrect)
                    {
                        MessageBox.Show(res.GetString("PleaseInsertAValidPhoneNo"), res.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
