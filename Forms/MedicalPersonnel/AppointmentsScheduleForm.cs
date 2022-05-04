
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
        private readonly IAppointmentsDal appointmentsDal;

        Form prevForm;
        public ScheduleForm(HealthClinicEntities ctx, Form prevForm, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            scheduleDal = new ScheduleDal(_ctx);
            appointmentsDal = new AppointmentsDal(_ctx);
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

            ChangeControlsFont();
            //LoadUserSchedule();

            FillDaysOfWeekCombobox();
        }

        private void FillDaysOfWeekCombobox()
        {
            if (cbDaysOfWeek.Items.Count == 0)
            {
                foreach (string dayOfWeek in Enum.GetNames(typeof(HealthClinicEnums.DaysOfWeek)))
                {
                    cbDaysOfWeek.Items.Add(res.GetString(dayOfWeek));
                }
            }

            //MessageBox.Show(Convert.ToString(loggedInUser.Rights.Id));
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelSchedule.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void cbDaysOfWeek_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbAppointments.Text = "";

            var firstDayOfNextWeek = scheduleDal.StartOfWeek(DateTime.Today.AddDays(7));

            var selectedDay = firstDayOfNextWeek.AddDays(cbDaysOfWeek.SelectedIndex); //cbDaysOfWeek.SelectedIndex equals to selected day of week

            var allApointmentsForDay = appointmentsDal.GetAppointmentsForUserByUsernameAndDay(loggedInUser.Username, selectedDay);

            if (allApointmentsForDay.Count == 0)
            {
                tbAppointments.Text = $"{res.GetString("NoAppointmentsForDay")} {String.Format("{0:dd/MM/yyyy}", selectedDay.Date)}.";
            }
            else
            {
                var appointments = "";

                foreach (var appointment in allApointmentsForDay)
                {
                    var appointmentHour = $"{appointment.Date.Hour}:" + (appointment.Date.Minute > 0 ? Convert.ToString(appointment.Date.Minute) : "00");
                    appointments += $"{appointment.FirstName} {appointment.LastName} ({res.GetString("lblPhoneNo")} :{appointment.PhoneNumber}), {res.GetString("atHour")} {appointmentHour} \r\n";
                }

                tbAppointments.Text = appointments;
            }


        }
    }
}
