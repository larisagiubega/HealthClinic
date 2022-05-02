
namespace HealthClinic.Forms__Views_
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.btnEditDeleteNotice = new System.Windows.Forms.Button();
            this.btnCreateNotice = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnProcessInvoices = new System.Windows.Forms.Button();
            this.btnMedications = new System.Windows.Forms.Button();
            this.btnCheckAppointments = new System.Windows.Forms.Button();
            this.btnCreateSchedule = new System.Windows.Forms.Button();
            this.btnNoticeBoard = new System.Windows.Forms.Button();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelAdmin.Controls.Add(this.HealthClinic);
            this.panelAdmin.Controls.Add(this.btnEditDeleteNotice);
            this.panelAdmin.Controls.Add(this.btnCreateNotice);
            this.panelAdmin.Controls.Add(this.btnLogOut);
            this.panelAdmin.Controls.Add(this.btnProcessInvoices);
            this.panelAdmin.Controls.Add(this.btnMedications);
            this.panelAdmin.Controls.Add(this.btnCheckAppointments);
            this.panelAdmin.Controls.Add(this.btnCreateSchedule);
            this.panelAdmin.Controls.Add(this.btnNoticeBoard);
            this.panelAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(945, 680);
            this.panelAdmin.TabIndex = 0;
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
            // btnEditDeleteNotice
            // 
            this.btnEditDeleteNotice.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDeleteNotice.BackgroundImage = global::HealthClinic.Properties.Resources.edit_notice_board;
            this.btnEditDeleteNotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditDeleteNotice.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnEditDeleteNotice.Location = new System.Drawing.Point(474, 548);
            this.btnEditDeleteNotice.Name = "btnEditDeleteNotice";
            this.btnEditDeleteNotice.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnEditDeleteNotice.Size = new System.Drawing.Size(470, 130);
            this.btnEditDeleteNotice.TabIndex = 11;
            this.btnEditDeleteNotice.Text = "Edit notice";
            this.btnEditDeleteNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditDeleteNotice.UseVisualStyleBackColor = false;
            this.btnEditDeleteNotice.Click += new System.EventHandler(this.btnEditNotice_Click);
            // 
            // btnCreateNotice
            // 
            this.btnCreateNotice.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateNotice.BackgroundImage = global::HealthClinic.Properties.Resources.create_notice_board;
            this.btnCreateNotice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateNotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateNotice.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnCreateNotice.Location = new System.Drawing.Point(474, 417);
            this.btnCreateNotice.Name = "btnCreateNotice";
            this.btnCreateNotice.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnCreateNotice.Size = new System.Drawing.Size(470, 130);
            this.btnCreateNotice.TabIndex = 10;
            this.btnCreateNotice.Text = "Create notice";
            this.btnCreateNotice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateNotice.UseVisualStyleBackColor = false;
            this.btnCreateNotice.Click += new System.EventHandler(this.btnCreateNotice_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Impact", 12F);
            this.btnLogOut.Location = new System.Drawing.Point(835, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(105, 40);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnProcessInvoices
            // 
            this.btnProcessInvoices.BackColor = System.Drawing.Color.Transparent;
            this.btnProcessInvoices.BackgroundImage = global::HealthClinic.Properties.Resources.invoice;
            this.btnProcessInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcessInvoices.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnProcessInvoices.Location = new System.Drawing.Point(0, 417);
            this.btnProcessInvoices.Name = "btnProcessInvoices";
            this.btnProcessInvoices.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnProcessInvoices.Size = new System.Drawing.Size(470, 130);
            this.btnProcessInvoices.TabIndex = 8;
            this.btnProcessInvoices.Text = "Check/validate invoices";
            this.btnProcessInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessInvoices.UseVisualStyleBackColor = false;
            this.btnProcessInvoices.Click += new System.EventHandler(this.btnProcessInvoices_Click);
            // 
            // btnMedications
            // 
            this.btnMedications.BackColor = System.Drawing.Color.Transparent;
            this.btnMedications.BackgroundImage = global::HealthClinic.Properties.Resources.medicine;
            this.btnMedications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedications.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedications.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnMedications.ForeColor = System.Drawing.Color.Black;
            this.btnMedications.Location = new System.Drawing.Point(1, 548);
            this.btnMedications.Name = "btnMedications";
            this.btnMedications.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnMedications.Size = new System.Drawing.Size(470, 130);
            this.btnMedications.TabIndex = 7;
            this.btnMedications.Text = "Keep track of medications";
            this.btnMedications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedications.UseVisualStyleBackColor = false;
            this.btnMedications.Click += new System.EventHandler(this.btnMedications_Click);
            // 
            // btnCheckAppointments
            // 
            this.btnCheckAppointments.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckAppointments.BackgroundImage = global::HealthClinic.Properties.Resources.appointment;
            this.btnCheckAppointments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckAppointments.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnCheckAppointments.Location = new System.Drawing.Point(0, 286);
            this.btnCheckAppointments.Name = "btnCheckAppointments";
            this.btnCheckAppointments.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnCheckAppointments.Size = new System.Drawing.Size(470, 130);
            this.btnCheckAppointments.TabIndex = 6;
            this.btnCheckAppointments.Text = "Save appointments";
            this.btnCheckAppointments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckAppointments.UseVisualStyleBackColor = false;
            this.btnCheckAppointments.Click += new System.EventHandler(this.btnValidateAppointments_Click);
            // 
            // btnCreateSchedule
            // 
            this.btnCreateSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateSchedule.BackgroundImage = global::HealthClinic.Properties.Resources.create_schedule;
            this.btnCreateSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCreateSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreateSchedule.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnCreateSchedule.Location = new System.Drawing.Point(2, 154);
            this.btnCreateSchedule.Name = "btnCreateSchedule";
            this.btnCreateSchedule.Size = new System.Drawing.Size(942, 130);
            this.btnCreateSchedule.TabIndex = 5;
            this.btnCreateSchedule.Text = "Create schedule";
            this.btnCreateSchedule.UseVisualStyleBackColor = false;
            this.btnCreateSchedule.Click += new System.EventHandler(this.btnCreateSchedule_Click);
            // 
            // btnNoticeBoard
            // 
            this.btnNoticeBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnNoticeBoard.BackgroundImage = global::HealthClinic.Properties.Resources.notice_board;
            this.btnNoticeBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoticeBoard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNoticeBoard.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnNoticeBoard.Location = new System.Drawing.Point(474, 286);
            this.btnNoticeBoard.Name = "btnNoticeBoard";
            this.btnNoticeBoard.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNoticeBoard.Size = new System.Drawing.Size(470, 130);
            this.btnNoticeBoard.TabIndex = 4;
            this.btnNoticeBoard.Text = "Check notice board";
            this.btnNoticeBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoticeBoard.UseVisualStyleBackColor = false;
            this.btnNoticeBoard.Click += new System.EventHandler(this.btnNoticeBoard_Click);
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelAdmin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Button btnCreateSchedule;
        private System.Windows.Forms.Button btnNoticeBoard;
        private System.Windows.Forms.Button btnProcessInvoices;
        private System.Windows.Forms.Button btnMedications;
        private System.Windows.Forms.Button btnCheckAppointments;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCreateNotice;
        private System.Windows.Forms.Button btnEditDeleteNotice;
        private System.Windows.Forms.Label HealthClinic;
    }
}