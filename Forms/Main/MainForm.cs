using HealthClinic.DAL;
using HealthClinic.Forms;
using HealthClinic.Localization;
using HealthClinic.Presenters;
using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Windows.Forms;

namespace HealthClinic
{
    public partial class MainForm : Form
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        public MainForm(HealthClinicEntities ctx)
        {
            InitializeComponent();

            _ctx = ctx;
            UseExcel.appointmentsPresenter = new AppointmentsPresenter(_ctx);
        }

        private void FillLanguageCombobox()
        {
            var languageLong = HealthClinicLocalization.GetLanguageByShortString(language);

            cbLanguage.Items.Add(res.GetString("English"));
            cbLanguage.Items.Add(res.GetString("Romanian"));
            cbLanguage.Items.Add(res.GetString("German"));

            cbLanguage.SelectedItem = res.GetString(string.IsNullOrEmpty(languageLong) ? "English" : languageLong);
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelMain.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_ctx);
            loginForm.Show();
            this.Hide();
        }

        private void btnContinueAsPatient_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm(_ctx, this);
            patientForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cbLanguage_SelectedValueChanged(object sender, EventArgs e)
        {
            //get current language
            language = HealthClinicLocalization.GetLanguage();

            //get selected language
            var selectedLanguage = Convert.ToString(cbLanguage.SelectedItem);

            //if(selected language in english != current language)
            if (!HealthClinicLocalization.GetResourceNameByValue(res, selectedLanguage).ToUpper().Equals(HealthClinicLocalization.GetLanguageByShortString(language).ToUpper()))
            {
                //get language key of selected language
                var languageKey = HealthClinicLocalization.GetResourceNameByValue(res, selectedLanguage);

                //new language is now selected language
                var newLanguage = HealthClinicLocalization.GetLanguageByLongString(languageKey);

                //Localization.Localization.FillControlsByLanguage(res, language, panelMain);

                //add in language file the new language code
                HealthClinicLocalization.SetLanguage(newLanguage);

                DialogResult result = MessageBox.Show(res.GetString("ApplicationWillRestart"), "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    Application.Restart();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            ChangeControlsFont();
            FillLanguageCombobox();

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelMain);

        }
    }
}
