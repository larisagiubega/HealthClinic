
namespace HealthClinic.Forms.Patient
{
    using HealthClinic.DTOs;
    using HealthClinic.Enums;
    using HealthClinic.Forms__Views_.Patient;
    using HealthClinic.Localization;
    using HealthClinic.Presenters;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Resources;
    using System.Windows.Forms;

    public partial class CheckDoctorsSchedule : Form
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();
        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        CheckDoctorsSchedulePresenter presenter;

        Form prevForm;
        public CheckDoctorsSchedule(HealthClinicEntities ctx, Form prevForm)
        {
            InitializeComponent();

            presenter = new CheckDoctorsSchedulePresenter(ctx);

            _ctx = ctx;
            this.prevForm = prevForm;
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void CheckDoctorsSchedule_Load(object sender, System.EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelCheckDoctorsSchedule);
            HealthClinicLocalization.FillControlsByLanguage(res, language, panelCardSchedule);

            FillDoctorsCombobox();
            ChangeControlsFont();
        }

        private void FillDoctorsCombobox()
        {
            cbDoctors.Items.Clear();

            var allDoctorsNames = presenter.GetAllDoctorsFullNames();

            cbDoctors.Items.AddRange(allDoctorsNames.ToArray());
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelCheckDoctorsSchedule.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
            foreach (Control control in panelCardSchedule.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void cbDoctors_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedDoctor = presenter.GetUserByFullName(Convert.ToString(cbDoctors.SelectedItem));

            var doctorsSchedule = presenter.GetAllSchedulesForUserByUsername(selectedDoctor.Username);

            FillScheduleDays(doctorsSchedule);
        }

        private void FillScheduleDays(List<ScheduleDto> doctorsSchedule)
        {
            var firstDayOfNextWeek = presenter.GetFirstDayOfFollowingWeek(); // always Monday

            doctorsSchedule = doctorsSchedule.Where(x => x.Date >= firstDayOfNextWeek).ToList();

            if (doctorsSchedule.Count == 0) //if the doctor has no schedule for the following week
            {
                FillNoSchedules();
            }

            foreach (var schedule in doctorsSchedule)
            {
                var dayOfWeek = (int)schedule.Date.DayOfWeek - 1; //subtract 1 because of ISO

                var shiftInterval = presenter.GetStartEndHourByShiftId(schedule.IdShift);
                var shiftHours = $"{shiftInterval} ({schedule.Date.Day}.{schedule.Date.Month.ToString("00")})";

                switch ((HealthClinicEnums.DaysOfWeek)dayOfWeek)
                {
                    case HealthClinicEnums.DaysOfWeek.Monday:
                        {
                            tbMonday.Text = shiftHours;
                            break;
                        }
                    case HealthClinicEnums.DaysOfWeek.Tuesday:
                        {
                            tbTuesday.Text = shiftHours;
                            break;
                        }
                    case HealthClinicEnums.DaysOfWeek.Wednesday:
                        {
                            tbWednesday.Text = shiftHours;
                            break;
                        }
                    case HealthClinicEnums.DaysOfWeek.Thursday:
                        {
                            tbThursday.Text = shiftHours;
                            break;
                        }
                    case HealthClinicEnums.DaysOfWeek.Friday:
                        {
                            tbFriday.Text = shiftHours;
                            break;
                        }
                    case HealthClinicEnums.DaysOfWeek.Saturday:
                        {
                            tbSaturday.Text = shiftHours;
                            break;
                        }
                    case HealthClinicEnums.DaysOfWeek.Sunday:
                        {
                            tbSunday.Text = shiftHours;
                            break;
                        }
                    default: break;
                }
            }

            foreach (Control dayTextbox in panelCardSchedule.Controls)
            {
                if (dayTextbox is TextBox && string.IsNullOrEmpty(((TextBox)dayTextbox).Text))
                {
                    ((TextBox)dayTextbox).Text = res.GetString("Free");
                }
            }
        }

        private void FillNoSchedules()
        {
            foreach (Control dayTextbox in panelCardSchedule.Controls)
            {
                if (dayTextbox is TextBox)
                {
                    ((TextBox)dayTextbox).Text = res.GetString("Free");
                }
            }
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm checkSymptomsForm = new AppointmentsForm(_ctx, this);
            checkSymptomsForm.Show();
            this.Hide();
        }
    }
}
