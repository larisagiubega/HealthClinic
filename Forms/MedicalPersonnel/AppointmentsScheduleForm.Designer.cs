
namespace HealthClinic.Forms__Views_.MedicalPersonnel
{
    partial class ScheduleForm
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
            this.panelSchedule = new System.Windows.Forms.Panel();
            this.lblSelectScheduleDay = new System.Windows.Forms.Label();
            this.cbDaysOfWeek = new System.Windows.Forms.ComboBox();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.lblContactAdministrator = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblYourAppointments = new System.Windows.Forms.Label();
            this.tbAppointments = new System.Windows.Forms.TextBox();
            this.panelSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSchedule
            // 
            this.panelSchedule.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelSchedule.Controls.Add(this.tbAppointments);
            this.panelSchedule.Controls.Add(this.lblYourAppointments);
            this.panelSchedule.Controls.Add(this.lblSelectScheduleDay);
            this.panelSchedule.Controls.Add(this.cbDaysOfWeek);
            this.panelSchedule.Controls.Add(this.HealthClinic);
            this.panelSchedule.Controls.Add(this.lblContactAdministrator);
            this.panelSchedule.Controls.Add(this.btnBack);
            this.panelSchedule.Location = new System.Drawing.Point(0, 0);
            this.panelSchedule.Name = "panelSchedule";
            this.panelSchedule.Size = new System.Drawing.Size(945, 680);
            this.panelSchedule.TabIndex = 1;
            // 
            // lblSelectScheduleDay
            // 
            this.lblSelectScheduleDay.AutoSize = true;
            this.lblSelectScheduleDay.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectScheduleDay.Font = new System.Drawing.Font("Impact", 12F);
            this.lblSelectScheduleDay.Location = new System.Drawing.Point(66, 175);
            this.lblSelectScheduleDay.Name = "lblSelectScheduleDay";
            this.lblSelectScheduleDay.Size = new System.Drawing.Size(211, 20);
            this.lblSelectScheduleDay.TabIndex = 2;
            this.lblSelectScheduleDay.Text = "Please select a day of the week";
            // 
            // cbDaysOfWeek
            // 
            this.cbDaysOfWeek.Font = new System.Drawing.Font("Impact", 12F);
            this.cbDaysOfWeek.FormattingEnabled = true;
            this.cbDaysOfWeek.Location = new System.Drawing.Point(70, 207);
            this.cbDaysOfWeek.Name = "cbDaysOfWeek";
            this.cbDaysOfWeek.Size = new System.Drawing.Size(207, 28);
            this.cbDaysOfWeek.TabIndex = 3;
            this.cbDaysOfWeek.SelectionChangeCommitted += new System.EventHandler(this.cbDaysOfWeek_SelectionChangeCommitted);
            // 
            // HealthClinic
            // 
            this.HealthClinic.AutoSize = true;
            this.HealthClinic.BackColor = System.Drawing.Color.Transparent;
            this.HealthClinic.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.HealthClinic.Location = new System.Drawing.Point(60, 50);
            this.HealthClinic.Name = "HealthClinic";
            this.HealthClinic.Size = new System.Drawing.Size(287, 60);
            this.HealthClinic.TabIndex = 17;
            this.HealthClinic.Text = "Health clinic";
            // 
            // lblContactAdministrator
            // 
            this.lblContactAdministrator.AutoSize = true;
            this.lblContactAdministrator.BackColor = System.Drawing.Color.Transparent;
            this.lblContactAdministrator.Font = new System.Drawing.Font("Impact", 12F);
            this.lblContactAdministrator.Location = new System.Drawing.Point(66, 629);
            this.lblContactAdministrator.Name = "lblContactAdministrator";
            this.lblContactAdministrator.Size = new System.Drawing.Size(351, 20);
            this.lblContactAdministrator.TabIndex = 16;
            this.lblContactAdministrator.Text = "* Please contact administrator for eventual changes.";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::HealthClinic.Properties.Resources.back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblYourAppointments
            // 
            this.lblYourAppointments.AutoSize = true;
            this.lblYourAppointments.BackColor = System.Drawing.Color.Transparent;
            this.lblYourAppointments.Font = new System.Drawing.Font("Impact", 12F);
            this.lblYourAppointments.Location = new System.Drawing.Point(66, 280);
            this.lblYourAppointments.Name = "lblYourAppointments";
            this.lblYourAppointments.Size = new System.Drawing.Size(134, 20);
            this.lblYourAppointments.TabIndex = 18;
            this.lblYourAppointments.Text = "Your appointments:";
            // 
            // tbAppointments
            // 
            this.tbAppointments.Font = new System.Drawing.Font("Impact", 12F);
            this.tbAppointments.Location = new System.Drawing.Point(70, 313);
            this.tbAppointments.Multiline = true;
            this.tbAppointments.Name = "tbAppointments";
            this.tbAppointments.ReadOnly = true;
            this.tbAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAppointments.Size = new System.Drawing.Size(841, 269);
            this.tbAppointments.TabIndex = 19;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelSchedule);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check schedule";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScheduleForm_FormClosed);
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.panelSchedule.ResumeLayout(false);
            this.panelSchedule.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSchedule;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblContactAdministrator;
        private System.Windows.Forms.Label HealthClinic;
        private System.Windows.Forms.Label lblSelectScheduleDay;
        private System.Windows.Forms.ComboBox cbDaysOfWeek;
        private System.Windows.Forms.Label lblYourAppointments;
        private System.Windows.Forms.TextBox tbAppointments;
    }
}