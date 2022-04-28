
namespace HealthClinic.Forms__Views_.Administrator
{
    partial class CreateScheduleForm
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
            this.panelCreateSchedule = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbPickShift = new System.Windows.Forms.ComboBox();
            this.lblPickShift = new System.Windows.Forms.Label();
            this.cbDaysOfWeek = new System.Windows.Forms.ComboBox();
            this.lblPickDayOfWeek = new System.Windows.Forms.Label();
            this.lblPickUser = new System.Windows.Forms.Label();
            this.cbPickUser = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.panelCreateSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateSchedule
            // 
            this.panelCreateSchedule.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelCreateSchedule.Controls.Add(this.HealthClinic);
            this.panelCreateSchedule.Controls.Add(this.btnSave);
            this.panelCreateSchedule.Controls.Add(this.cbPickShift);
            this.panelCreateSchedule.Controls.Add(this.lblPickShift);
            this.panelCreateSchedule.Controls.Add(this.cbDaysOfWeek);
            this.panelCreateSchedule.Controls.Add(this.lblPickDayOfWeek);
            this.panelCreateSchedule.Controls.Add(this.lblPickUser);
            this.panelCreateSchedule.Controls.Add(this.cbPickUser);
            this.panelCreateSchedule.Controls.Add(this.btnBack);
            this.panelCreateSchedule.Location = new System.Drawing.Point(0, 0);
            this.panelCreateSchedule.Name = "panelCreateSchedule";
            this.panelCreateSchedule.Size = new System.Drawing.Size(945, 680);
            this.panelCreateSchedule.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Impact", 12F);
            this.btnSave.Location = new System.Drawing.Point(43, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbPickShift
            // 
            this.cbPickShift.BackColor = System.Drawing.Color.White;
            this.cbPickShift.Font = new System.Drawing.Font("Impact", 12F);
            this.cbPickShift.FormattingEnabled = true;
            this.cbPickShift.Location = new System.Drawing.Point(42, 357);
            this.cbPickShift.Name = "cbPickShift";
            this.cbPickShift.Size = new System.Drawing.Size(305, 28);
            this.cbPickShift.TabIndex = 6;
            // 
            // lblPickShift
            // 
            this.lblPickShift.AutoSize = true;
            this.lblPickShift.BackColor = System.Drawing.Color.Transparent;
            this.lblPickShift.Font = new System.Drawing.Font("Impact", 12F);
            this.lblPickShift.Location = new System.Drawing.Point(40, 332);
            this.lblPickShift.Name = "lblPickShift";
            this.lblPickShift.Size = new System.Drawing.Size(70, 20);
            this.lblPickShift.TabIndex = 5;
            this.lblPickShift.Text = "Pick shift";
            // 
            // cbDaysOfWeek
            // 
            this.cbDaysOfWeek.BackColor = System.Drawing.Color.White;
            this.cbDaysOfWeek.Font = new System.Drawing.Font("Impact", 12F);
            this.cbDaysOfWeek.FormattingEnabled = true;
            this.cbDaysOfWeek.Location = new System.Drawing.Point(42, 260);
            this.cbDaysOfWeek.Name = "cbDaysOfWeek";
            this.cbDaysOfWeek.Size = new System.Drawing.Size(305, 28);
            this.cbDaysOfWeek.TabIndex = 4;
            // 
            // lblPickDayOfWeek
            // 
            this.lblPickDayOfWeek.AutoSize = true;
            this.lblPickDayOfWeek.BackColor = System.Drawing.Color.Transparent;
            this.lblPickDayOfWeek.Font = new System.Drawing.Font("Impact", 12F);
            this.lblPickDayOfWeek.Location = new System.Drawing.Point(39, 235);
            this.lblPickDayOfWeek.Name = "lblPickDayOfWeek";
            this.lblPickDayOfWeek.Size = new System.Drawing.Size(140, 20);
            this.lblPickDayOfWeek.TabIndex = 3;
            this.lblPickDayOfWeek.Text = "Pick day of the week";
            // 
            // lblPickUser
            // 
            this.lblPickUser.AutoSize = true;
            this.lblPickUser.BackColor = System.Drawing.Color.Transparent;
            this.lblPickUser.Font = new System.Drawing.Font("Impact", 12F);
            this.lblPickUser.Location = new System.Drawing.Point(39, 145);
            this.lblPickUser.Name = "lblPickUser";
            this.lblPickUser.Size = new System.Drawing.Size(70, 20);
            this.lblPickUser.TabIndex = 2;
            this.lblPickUser.Text = "Pick user";
            // 
            // cbPickUser
            // 
            this.cbPickUser.BackColor = System.Drawing.Color.White;
            this.cbPickUser.Font = new System.Drawing.Font("Impact", 12F);
            this.cbPickUser.FormattingEnabled = true;
            this.cbPickUser.Location = new System.Drawing.Point(42, 170);
            this.cbPickUser.Name = "cbPickUser";
            this.cbPickUser.Size = new System.Drawing.Size(305, 28);
            this.cbPickUser.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::HealthClinic.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F);
            this.btnBack.Location = new System.Drawing.Point(5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 40);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HealthClinic
            // 
            this.HealthClinic.AutoSize = true;
            this.HealthClinic.BackColor = System.Drawing.Color.Transparent;
            this.HealthClinic.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.HealthClinic.Location = new System.Drawing.Point(60, 50);
            this.HealthClinic.Name = "HealthClinic";
            this.HealthClinic.Size = new System.Drawing.Size(287, 60);
            this.HealthClinic.TabIndex = 14;
            this.HealthClinic.Text = "Health clinic";
            // 
            // CreateScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelCreateSchedule);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "CreateScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateScheduleForm";
            this.Load += new System.EventHandler(this.CreateScheduleForm_Load);
            this.panelCreateSchedule.ResumeLayout(false);
            this.panelCreateSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateSchedule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPickUser;
        private System.Windows.Forms.ComboBox cbPickUser;
        private System.Windows.Forms.Label lblPickDayOfWeek;
        private System.Windows.Forms.ComboBox cbDaysOfWeek;
        private System.Windows.Forms.Label lblPickShift;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbPickShift;
        private System.Windows.Forms.Label HealthClinic;
    }
}