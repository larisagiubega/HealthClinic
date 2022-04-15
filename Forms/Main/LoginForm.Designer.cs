
namespace HealthClinic.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.panelCardLogin = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.cbPasswordVisible = new System.Windows.Forms.CheckBox();
            this.btnContinueAsPatient = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.panelCardLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelLogin.Controls.Add(this.HealthClinic);
            this.panelLogin.Controls.Add(this.panelCardLogin);
            this.panelLogin.Controls.Add(this.lblAccount);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(945, 680);
            this.panelLogin.TabIndex = 1;
            // 
            // HealthClinic
            // 
            this.HealthClinic.AutoSize = true;
            this.HealthClinic.BackColor = System.Drawing.Color.Transparent;
            this.HealthClinic.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.HealthClinic.Location = new System.Drawing.Point(60, 50);
            this.HealthClinic.Name = "HealthClinic";
            this.HealthClinic.Size = new System.Drawing.Size(287, 60);
            this.HealthClinic.TabIndex = 11;
            this.HealthClinic.Text = "Health clinic";
            // 
            // panelCardLogin
            // 
            this.panelCardLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(161)))), ((int)(((byte)(180)))));
            this.panelCardLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardLogin.Controls.Add(this.tbPassword);
            this.panelCardLogin.Controls.Add(this.lblWarning);
            this.panelCardLogin.Controls.Add(this.lblOr);
            this.panelCardLogin.Controls.Add(this.cbPasswordVisible);
            this.panelCardLogin.Controls.Add(this.btnContinueAsPatient);
            this.panelCardLogin.Controls.Add(this.lblPassword);
            this.panelCardLogin.Controls.Add(this.btnLogin);
            this.panelCardLogin.Controls.Add(this.tbUsername);
            this.panelCardLogin.Controls.Add(this.lblUsername);
            this.panelCardLogin.Location = new System.Drawing.Point(289, 185);
            this.panelCardLogin.Name = "panelCardLogin";
            this.panelCardLogin.Size = new System.Drawing.Size(370, 410);
            this.panelCardLogin.TabIndex = 10;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Impact", 12F);
            this.tbPassword.Location = new System.Drawing.Point(92, 163);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(183, 27);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPassword_MouseClick);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Impact", 12F);
            this.lblWarning.Location = new System.Drawing.Point(88, 229);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(156, 20);
            this.lblWarning.TabIndex = 5;
            this.lblWarning.Text = "Here comes a warning.";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.BackColor = System.Drawing.Color.Transparent;
            this.lblOr.Font = new System.Drawing.Font("Impact", 12F);
            this.lblOr.Location = new System.Drawing.Point(162, 304);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(43, 20);
            this.lblOr.TabIndex = 7;
            this.lblOr.Text = "...or....";
            // 
            // cbPasswordVisible
            // 
            this.cbPasswordVisible.AutoSize = true;
            this.cbPasswordVisible.BackColor = System.Drawing.Color.Transparent;
            this.cbPasswordVisible.Font = new System.Drawing.Font("Impact", 12F);
            this.cbPasswordVisible.Location = new System.Drawing.Point(93, 195);
            this.cbPasswordVisible.Name = "cbPasswordVisible";
            this.cbPasswordVisible.Size = new System.Drawing.Size(139, 24);
            this.cbPasswordVisible.TabIndex = 9;
            this.cbPasswordVisible.Text = "Password visible";
            this.cbPasswordVisible.UseVisualStyleBackColor = false;
            this.cbPasswordVisible.CheckedChanged += new System.EventHandler(this.cbPasswordVisible_CheckedChanged);
            // 
            // btnContinueAsPatient
            // 
            this.btnContinueAsPatient.AutoEllipsis = true;
            this.btnContinueAsPatient.BackColor = System.Drawing.Color.White;
            this.btnContinueAsPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinueAsPatient.Font = new System.Drawing.Font("Impact", 12F);
            this.btnContinueAsPatient.Location = new System.Drawing.Point(92, 335);
            this.btnContinueAsPatient.Name = "btnContinueAsPatient";
            this.btnContinueAsPatient.Size = new System.Drawing.Size(183, 35);
            this.btnContinueAsPatient.TabIndex = 6;
            this.btnContinueAsPatient.Text = "Continue as patient";
            this.btnContinueAsPatient.UseVisualStyleBackColor = false;
            this.btnContinueAsPatient.Click += new System.EventHandler(this.btnContinueAsPatient_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Impact", 12F);
            this.lblPassword.Location = new System.Drawing.Point(93, 140);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Impact", 12F);
            this.btnLogin.Location = new System.Drawing.Point(92, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Impact", 12F);
            this.tbUsername.Location = new System.Drawing.Point(92, 98);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(183, 27);
            this.tbUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Impact", 12F);
            this.lblUsername.Location = new System.Drawing.Point(88, 75);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(76, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(75, 125);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(0, 25);
            this.lblAccount.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelCardLogin.ResumeLayout(false);
            this.panelCardLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnContinueAsPatient;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.CheckBox cbPasswordVisible;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panelCardLogin;
        private System.Windows.Forms.Label HealthClinic;
    }
}