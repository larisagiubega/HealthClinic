
namespace HealthClinic.Forms__Views_.Administrator
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Resources;
    using System.Windows.Forms;
    using HealthClinic.Localization;
    using HealthClinic.Interfaces;
    using HealthClinic.Presenters;
    using HealthClinic.DTOs;
    public partial class CreateScheduleForm : Form
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();
        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        ISchedulePresenter schedulePresenter;

        static UserDto loggedInUser = null;

        Form prevForm;
        public CreateScheduleForm(HealthClinicEntities ctx, Form prevForm, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            this.prevForm = prevForm;
            loggedInUser = user;

            schedulePresenter = new SchedulePresenter(_ctx);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void CreateScheduleForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelCreateSchedule);

            FillUserCombobox();
            FillDaysOfWeekCombobox();
            FillShiftsCombobox();
        }

        private void FillShiftsCombobox()
        {
            var allShifts = schedulePresenter.GetAllShiftHours();

            var shiftsComboboxText = allShifts.Select(x => new
            {
                Text = $"{x.ShiftStart} - {x.ShiftEnd}"
            }).ToArray();

            cbPickShift.Items.AddRange(shiftsComboboxText.Select(x => x.Text).ToArray());

            cbPickShift.SelectedItem = cbPickShift.Items[0];
        }

        private void FillDaysOfWeekCombobox()
        {
            string[] daysOfWeek = schedulePresenter.GetDaysOfWeek();

            cbDaysOfWeek.Items.AddRange(daysOfWeek);

            cbDaysOfWeek.SelectedItem = cbDaysOfWeek.Items[0];
        }

        private void FillUserCombobox()
        {
            cbPickUser.Items.Clear();

            cbPickUser.Text = res.GetString("PleaseSelectUser");

            var medicalPersonnelFullNames = schedulePresenter.GetAllMedicalPersonnelFullNames();

            cbPickUser.Items.AddRange(medicalPersonnelFullNames);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var selectedUser = Convert.ToString(cbPickUser.SelectedItem);

            if (string.IsNullOrEmpty(selectedUser))
            {
                MessageBox.Show(res.GetString("PleaseSelectUser"), res.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var selectedDayValue = cbDaysOfWeek.SelectedIndex;

                var selectedShift = Convert.ToString(cbPickShift.SelectedItem);

                var user = schedulePresenter.GetUserByFullName(selectedUser);
                var firstDayOfFollowingWeek = schedulePresenter.GetFirstDayOfFollowingWeek();

                var selectedDay = firstDayOfFollowingWeek.AddDays(selectedDayValue);

                var shiftSplit = selectedShift.Split('-');

                var startHour = shiftSplit[0].Trim();
                var endHour = shiftSplit[1].Trim();

                var shiftId = schedulePresenter.GetShiftIdByStartAndEndHour(startHour, endHour);

                ScheduleDto schedule = new ScheduleDto
                {
                    ChangedBy = loggedInUser.Username,
                    IdShift = shiftId,
                    Username = user.Username,
                    Date = selectedDay
                };

                //a person cannot work multiple shifts the same day 
                if (!schedulePresenter.ExistsSchedule(schedule))
                {
                    if (schedulePresenter.AddSchedule(schedule))
                    {
                        MessageBox.Show(res.GetString("ScheduleSaved"));
                    }
                }
                else
                {
                    MessageBox.Show(res.GetString("MultipleShiftsPerDayNotPossible"), res.GetString("Warning"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
