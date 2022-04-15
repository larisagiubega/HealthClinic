
namespace HealthClinic.Forms__Views_.Administrator
{
    using HealthClinic.DTOs;
    using HealthClinic.Localization;
    using System;
    using System.Resources;
    using System.Windows.Forms;
    public partial class ProcessInvoices : Form
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();
        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        static UserDto loggedInUser = null;

        Form prevForm;
        public ProcessInvoices(HealthClinicEntities ctx, Form prevForm, UserDto user)
        {
            InitializeComponent();

            _ctx = ctx;
            this.prevForm = prevForm;
            loggedInUser = user;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void ProcessInvoices_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelProcessInvoices);
        }
    }
}
