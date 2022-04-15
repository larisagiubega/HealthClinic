
namespace HealthClinic.Forms__Views_.Patient
{
    partial class AppointmentsForm
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
            this.panelAppointments = new System.Windows.Forms.Panel();
            this.panelCardAppointments = new System.Windows.Forms.Panel();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblAppointmentHour = new System.Windows.Forms.Label();
            this.cbAppointmentHour = new System.Windows.Forms.ComboBox();
            this.panelAppointments.SuspendLayout();
            this.panelCardAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAppointments
            // 
            this.panelAppointments.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelAppointments.Controls.Add(this.panelCardAppointments);
            this.panelAppointments.Controls.Add(this.HealthClinic);
            this.panelAppointments.Controls.Add(this.btnBack);
            this.panelAppointments.Location = new System.Drawing.Point(0, 0);
            this.panelAppointments.Name = "panelAppointments";
            this.panelAppointments.Size = new System.Drawing.Size(945, 680);
            this.panelAppointments.TabIndex = 1;
            // 
            // panelCardAppointments
            // 
            this.panelCardAppointments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(161)))), ((int)(((byte)(180)))));
            this.panelCardAppointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCardAppointments.Controls.Add(this.cbAppointmentHour);
            this.panelCardAppointments.Controls.Add(this.lblAppointmentHour);
            this.panelCardAppointments.Controls.Add(this.cbYear);
            this.panelCardAppointments.Controls.Add(this.cbMonth);
            this.panelCardAppointments.Controls.Add(this.cbDay);
            this.panelCardAppointments.Controls.Add(this.cbDoctor);
            this.panelCardAppointments.Controls.Add(this.lblDoctorName);
            this.panelCardAppointments.Controls.Add(this.lblAppointmentDate);
            this.panelCardAppointments.Controls.Add(this.tbPhoneNumber);
            this.panelCardAppointments.Controls.Add(this.lblPhoneNo);
            this.panelCardAppointments.Controls.Add(this.tbLastName);
            this.panelCardAppointments.Controls.Add(this.lblLastName);
            this.panelCardAppointments.Controls.Add(this.btnSave);
            this.panelCardAppointments.Controls.Add(this.tbFirstName);
            this.panelCardAppointments.Controls.Add(this.lblFirstName);
            this.panelCardAppointments.Location = new System.Drawing.Point(289, 149);
            this.panelCardAppointments.Name = "panelCardAppointments";
            this.panelCardAppointments.Size = new System.Drawing.Size(372, 470);
            this.panelCardAppointments.TabIndex = 14;
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.White;
            this.cbYear.Font = new System.Drawing.Font("Impact", 12F);
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(203, 228);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(72, 28);
            this.cbYear.TabIndex = 12;
            // 
            // cbMonth
            // 
            this.cbMonth.BackColor = System.Drawing.Color.White;
            this.cbMonth.Font = new System.Drawing.Font("Impact", 12F);
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(141, 228);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(56, 28);
            this.cbMonth.TabIndex = 11;
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.Color.White;
            this.cbDay.Font = new System.Drawing.Font("Impact", 12F);
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(92, 228);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(43, 28);
            this.cbDay.TabIndex = 10;
            // 
            // cbDoctor
            // 
            this.cbDoctor.BackColor = System.Drawing.Color.White;
            this.cbDoctor.Font = new System.Drawing.Font("Impact", 12F);
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(92, 350);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(183, 28);
            this.cbDoctor.TabIndex = 9;
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorName.Font = new System.Drawing.Font("Impact", 12F);
            this.lblDoctorName.Location = new System.Drawing.Point(93, 327);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(53, 20);
            this.lblDoctorName.TabIndex = 8;
            this.lblDoctorName.Text = "Doctor";
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Impact", 12F);
            this.lblAppointmentDate.Location = new System.Drawing.Point(93, 205);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(122, 20);
            this.lblAppointmentDate.TabIndex = 7;
            this.lblAppointmentDate.Text = "Appointment date";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Impact", 12F);
            this.tbPhoneNumber.Location = new System.Drawing.Point(92, 164);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(183, 27);
            this.tbPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNo.Font = new System.Drawing.Font("Impact", 12F);
            this.lblPhoneNo.Location = new System.Drawing.Point(93, 141);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(102, 20);
            this.lblPhoneNo.TabIndex = 5;
            this.lblPhoneNo.Text = "Phone number";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Impact", 12F);
            this.tbLastName.Location = new System.Drawing.Point(92, 98);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(183, 27);
            this.tbLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Impact", 12F);
            this.lblLastName.Location = new System.Drawing.Point(93, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last name";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Impact", 12F);
            this.btnSave.Location = new System.Drawing.Point(92, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(183, 35);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Impact", 12F);
            this.tbFirstName.Location = new System.Drawing.Point(92, 36);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(183, 27);
            this.tbFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Impact", 12F);
            this.lblFirstName.Location = new System.Drawing.Point(88, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First name";
            // 
            // HealthClinic
            // 
            this.HealthClinic.AutoSize = true;
            this.HealthClinic.BackColor = System.Drawing.Color.Transparent;
            this.HealthClinic.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.HealthClinic.Location = new System.Drawing.Point(60, 50);
            this.HealthClinic.Name = "HealthClinic";
            this.HealthClinic.Size = new System.Drawing.Size(287, 60);
            this.HealthClinic.TabIndex = 13;
            this.HealthClinic.Text = "Health clinic";
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
            // lblAppointmentHour
            // 
            this.lblAppointmentHour.AutoSize = true;
            this.lblAppointmentHour.BackColor = System.Drawing.Color.Transparent;
            this.lblAppointmentHour.Font = new System.Drawing.Font("Impact", 12F);
            this.lblAppointmentHour.Location = new System.Drawing.Point(93, 271);
            this.lblAppointmentHour.Name = "lblAppointmentHour";
            this.lblAppointmentHour.Size = new System.Drawing.Size(123, 20);
            this.lblAppointmentHour.TabIndex = 13;
            this.lblAppointmentHour.Text = "Appointment hour";
            // 
            // cbAppointmentHour
            // 
            this.cbAppointmentHour.BackColor = System.Drawing.Color.White;
            this.cbAppointmentHour.Font = new System.Drawing.Font("Impact", 12F);
            this.cbAppointmentHour.FormattingEnabled = true;
            this.cbAppointmentHour.Location = new System.Drawing.Point(92, 294);
            this.cbAppointmentHour.Name = "cbAppointmentHour";
            this.cbAppointmentHour.Size = new System.Drawing.Size(183, 28);
            this.cbAppointmentHour.TabIndex = 14;
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelAppointments);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "AppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentsForm_FormClosed);
            this.Load += new System.EventHandler(this.AppointmentsForm_Load);
            this.panelAppointments.ResumeLayout(false);
            this.panelAppointments.PerformLayout();
            this.panelCardAppointments.ResumeLayout(false);
            this.panelCardAppointments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAppointments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label HealthClinic;
        private System.Windows.Forms.Panel panelCardAppointments;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label lblAppointmentHour;
        private System.Windows.Forms.ComboBox cbAppointmentHour;
    }
}