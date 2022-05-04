
namespace HealthClinic.Forms
{
    partial class PatientForm
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
            this.panelPatient = new System.Windows.Forms.Panel();
            this.btnCheckSchedules = new System.Windows.Forms.Button();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNoticeBoard = new System.Windows.Forms.Button();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnCheckSymptoms = new System.Windows.Forms.Button();
            this.panelPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPatient
            // 
            this.panelPatient.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelPatient.Controls.Add(this.btnCheckSchedules);
            this.panelPatient.Controls.Add(this.HealthClinic);
            this.panelPatient.Controls.Add(this.btnBack);
            this.panelPatient.Controls.Add(this.btnNoticeBoard);
            this.panelPatient.Controls.Add(this.btnAppointments);
            this.panelPatient.Controls.Add(this.btnCheckSymptoms);
            this.panelPatient.Location = new System.Drawing.Point(0, 0);
            this.panelPatient.Name = "panelPatient";
            this.panelPatient.Size = new System.Drawing.Size(945, 680);
            this.panelPatient.TabIndex = 0;
            // 
            // btnCheckSchedules
            // 
            this.btnCheckSchedules.BackgroundImage = global::HealthClinic.Properties.Resources.check_schedule;
            this.btnCheckSchedules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCheckSchedules.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnCheckSchedules.Location = new System.Drawing.Point(-2, 557);
            this.btnCheckSchedules.Name = "btnCheckSchedules";
            this.btnCheckSchedules.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnCheckSchedules.Size = new System.Drawing.Size(948, 130);
            this.btnCheckSchedules.TabIndex = 13;
            this.btnCheckSchedules.Text = "Check doctors\' schedule";
            this.btnCheckSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckSchedules.UseVisualStyleBackColor = true;
            this.btnCheckSchedules.Click += new System.EventHandler(this.btnCheckSchedules_Click);
            // 
            // HealthClinic
            // 
            this.HealthClinic.AutoSize = true;
            this.HealthClinic.BackColor = System.Drawing.Color.Transparent;
            this.HealthClinic.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.HealthClinic.Location = new System.Drawing.Point(60, 50);
            this.HealthClinic.Name = "HealthClinic";
            this.HealthClinic.Size = new System.Drawing.Size(287, 60);
            this.HealthClinic.TabIndex = 12;
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
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNoticeBoard
            // 
            this.btnNoticeBoard.BackgroundImage = global::HealthClinic.Properties.Resources.notice_board;
            this.btnNoticeBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoticeBoard.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnNoticeBoard.Location = new System.Drawing.Point(-2, 431);
            this.btnNoticeBoard.Name = "btnNoticeBoard";
            this.btnNoticeBoard.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNoticeBoard.Size = new System.Drawing.Size(948, 130);
            this.btnNoticeBoard.TabIndex = 2;
            this.btnNoticeBoard.Text = "Check notice board";
            this.btnNoticeBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoticeBoard.UseVisualStyleBackColor = true;
            this.btnNoticeBoard.Click += new System.EventHandler(this.btnNoticeBoard_Click);
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackgroundImage = global::HealthClinic.Properties.Resources.appointment;
            this.btnAppointments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppointments.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnAppointments.Location = new System.Drawing.Point(0, 304);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnAppointments.Size = new System.Drawing.Size(948, 130);
            this.btnAppointments.TabIndex = 1;
            this.btnAppointments.Text = "Make an appointment";
            this.btnAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointments.UseVisualStyleBackColor = true;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnCheckSymptoms
            // 
            this.btnCheckSymptoms.BackgroundImage = global::HealthClinic.Properties.Resources.check_symptoms;
            this.btnCheckSymptoms.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnCheckSymptoms.Location = new System.Drawing.Point(0, 177);
            this.btnCheckSymptoms.Name = "btnCheckSymptoms";
            this.btnCheckSymptoms.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnCheckSymptoms.Size = new System.Drawing.Size(948, 130);
            this.btnCheckSymptoms.TabIndex = 0;
            this.btnCheckSymptoms.Text = "Check symptoms";
            this.btnCheckSymptoms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckSymptoms.UseVisualStyleBackColor = true;
            this.btnCheckSymptoms.Click += new System.EventHandler(this.btnCheckSymptoms_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelPatient);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "PatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome, Patient!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PatientForm_FormClosed);
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panelPatient.ResumeLayout(false);
            this.panelPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPatient;
        private System.Windows.Forms.Button btnCheckSymptoms;
        private System.Windows.Forms.Button btnNoticeBoard;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label HealthClinic;
        private System.Windows.Forms.Button btnCheckSchedules;
    }
}