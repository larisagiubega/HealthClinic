
namespace HealthClinic.Forms__Views_.MedicalPersonnel
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Enums;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Resources;
    using System.Windows.Forms;
    public partial class ScheduleForm : Form
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        static UserDto loggedInUser = null;

        private readonly IScheduleDal scheduleDal;

        Form prevForm;
        public ScheduleForm(HealthClinicEntities ctx, Form prevForm, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            scheduleDal = new ScheduleDal(_ctx);
            this.prevForm = prevForm;
            loggedInUser = user;
        }

        private void ScheduleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelSchedule);
            HealthClinicLocalization.FillControlsByLanguage(res, language, panelCardSchedule);

            ChangeControlsFont();
            LoadUserSchedule();
            //if (loggedInUser.Rights.Id == (int)HealthClinicEnums.Rights.MedicalPersonnel)

        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelSchedule.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }

            foreach (Control control in panelCardSchedule.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void LoadUserSchedule()
        {
            var allSchedulesForUser = scheduleDal.GetAllSchedulesForUserByUsername(loggedInUser.Username).Where(x => x.Date >= scheduleDal.StartOfWeek(DateTime.Today.AddDays(7))).ToList();

            foreach (var schedule in allSchedulesForUser)
            {
                var dayOfWeek = (int)schedule.Date.DayOfWeek - 1; //subtract 1 because of ISO

                var shiftInterval = scheduleDal.GetStartEndHourByShiftId(schedule.IdShift);
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
    }
}
