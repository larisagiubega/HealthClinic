
namespace HealthClinic.Forms
{
    using HealthClinic.Forms__Views_;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;
    using HealthClinic.Localization;
    using HealthClinic.Interfaces;
    using HealthClinic.Presenters;
    using HealthClinic.DTOs;

    public partial class LoginForm : Form
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        IUserPresenter userPresenter;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        private List<UserDto> allAccounts = new List<UserDto>();

        public LoginForm(HealthClinicEntities ctx)
        {
            InitializeComponent();

            _ctx = ctx;

            userPresenter = new UserPresenter(_ctx);
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelLogin.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
            foreach (Control control in panelCardLogin.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text) || string.IsNullOrEmpty(tbUsername.Text))
            {
                lblWarning.Text = res.GetString("ProvideUsername");
            }
            else
            if (string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                lblWarning.Text = res.GetString("ProvidePassword");
            }
            else
            {
                var username = tbUsername.Text;
                var password = tbPassword.Text;

                if (userPresenter.UsernameExists(username.ToLower()))
                {
                    var account = userPresenter.GetUserByUsername(username.ToLower());

                    var rightId = account.Rights.Id;

                    var passwordFromDb = account.Password;
                    var encryptedPassword = userPresenter.Encrypt(password);

                    if (encryptedPassword.Trim().Equals(passwordFromDb.Trim()))
                    {
                        lblWarning.Text = "";

                        OpenFormByUserRight(username, rightId);
                    }
                    else
                    {
                        lblWarning.Text = res.GetString("ForgottenPassword");
                    }
                }
                else
                {
                    lblWarning.Text = res.GetString("ForgottenUsername");
                }
            }
        }

        private void OpenFormByUserRight(string username, int rightId)
        {
            var user = userPresenter.GetUserByUsername(username);

            switch (rightId)
            {
                case 1:
                    OpenAdministratorForm(_ctx, user);
                    break;
                case 2:
                    OpenMedicalPersonnelForm(_ctx, user);
                    break;
                default: break;
            }
        }

        private void OpenAdministratorForm(HealthClinicEntities ctx, UserDto user)
        {
            AdministratorForm administratorForm = new AdministratorForm(_ctx, user);
            administratorForm.Show();
            this.Hide();
        }
        private void OpenMedicalPersonnelForm(HealthClinicEntities ctx, UserDto user)
        {
            MedicalPersonnelForm medicalPersonnelForm = new MedicalPersonnelForm(_ctx, user);
            medicalPersonnelForm.Show();
            this.Hide();
        }

        private void tbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lblWarning.Text = res.GetString("CapsLockOn");
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 20)
            {
                if (Control.IsKeyLocked(Keys.CapsLock))
                {
                    lblWarning.Text = res.GetString("CapsLockOn");
                }
                else
                {
                    lblWarning.Text = "";
                }
            }
        }

        private void btnContinueAsPatient_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm(_ctx, this);
            patientForm.Show();
            this.Hide();
        }

        private void cbPasswordVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPasswordVisible.Checked == true) //if (password is visible)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            ChangeControlsFont();

            tbPassword.PasswordChar = '*';

            allAccounts = userPresenter.GetAllAccounts();
            HealthClinicLocalization.FillControlsByLanguage(res, language, panelLogin);
            HealthClinicLocalization.FillControlsByLanguage(res, language, panelCardLogin);
        }
    }
}
