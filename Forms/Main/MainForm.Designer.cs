
namespace HealthClinic
{
    partial class MainForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.lblSelectLanguage = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.btnContinueAsPatient = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelMain.Controls.Add(this.HealthClinic);
            this.panelMain.Controls.Add(this.lblSelectLanguage);
            this.panelMain.Controls.Add(this.cbLanguage);
            this.panelMain.Controls.Add(this.btnContinueAsPatient);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(945, 680);
            this.panelMain.TabIndex = 0;
            // 
            // HealthClinic
            // 
            this.HealthClinic.AutoSize = true;
            this.HealthClinic.BackColor = System.Drawing.Color.Transparent;
            this.HealthClinic.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.HealthClinic.Location = new System.Drawing.Point(60, 50);
            this.HealthClinic.Name = "HealthClinic";
            this.HealthClinic.Size = new System.Drawing.Size(287, 60);
            this.HealthClinic.TabIndex = 4;
            this.HealthClinic.Text = "Health clinic";
            // 
            // lblSelectLanguage
            // 
            this.lblSelectLanguage.AutoSize = true;
            this.lblSelectLanguage.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectLanguage.Font = new System.Drawing.Font("Impact", 12F);
            this.lblSelectLanguage.Location = new System.Drawing.Point(772, 10);
            this.lblSelectLanguage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectLanguage.Name = "lblSelectLanguage";
            this.lblSelectLanguage.Size = new System.Drawing.Size(113, 20);
            this.lblSelectLanguage.TabIndex = 3;
            this.lblSelectLanguage.Text = "Select language";
            // 
            // cbLanguage
            // 
            this.cbLanguage.Font = new System.Drawing.Font("Impact", 12F);
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(774, 34);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(162, 28);
            this.cbLanguage.TabIndex = 2;
            this.cbLanguage.SelectedValueChanged += new System.EventHandler(this.cbLanguage_SelectedValueChanged);
            // 
            // btnContinueAsPatient
            // 
            this.btnContinueAsPatient.BackColor = System.Drawing.Color.White;
            this.btnContinueAsPatient.BackgroundImage = global::HealthClinic.Properties.Resources.patient;
            this.btnContinueAsPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContinueAsPatient.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnContinueAsPatient.Location = new System.Drawing.Point(0, 418);
            this.btnContinueAsPatient.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnContinueAsPatient.Name = "btnContinueAsPatient";
            this.btnContinueAsPatient.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnContinueAsPatient.Size = new System.Drawing.Size(950, 264);
            this.btnContinueAsPatient.TabIndex = 1;
            this.btnContinueAsPatient.Text = "Continue as patient";
            this.btnContinueAsPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContinueAsPatient.UseVisualStyleBackColor = false;
            this.btnContinueAsPatient.Click += new System.EventHandler(this.btnContinueAsPatient_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImage = global::HealthClinic.Properties.Resources.doctor;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogin.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Location = new System.Drawing.Point(2, 170);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(948, 250);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Log in";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 688);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health clinic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnContinueAsPatient;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblSelectLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.Label HealthClinic;
    }
}

