
namespace HealthClinic.Forms__Views_
{
    partial class MedicalPersonnelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalPersonnelForm));
            this.panelMedicalPersonnel = new System.Windows.Forms.Panel();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnNoticeBoard = new System.Windows.Forms.Button();
            this.panelMedicalPersonnel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMedicalPersonnel
            // 
            this.panelMedicalPersonnel.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelMedicalPersonnel.Controls.Add(this.HealthClinic);
            this.panelMedicalPersonnel.Controls.Add(this.btnLogOut);
            this.panelMedicalPersonnel.Controls.Add(this.btnSchedule);
            this.panelMedicalPersonnel.Controls.Add(this.btnNoticeBoard);
            this.panelMedicalPersonnel.Location = new System.Drawing.Point(0, 0);
            this.panelMedicalPersonnel.Name = "panelMedicalPersonnel";
            this.panelMedicalPersonnel.Size = new System.Drawing.Size(945, 680);
            this.panelMedicalPersonnel.TabIndex = 0;
            // 
            // HealthClinic
            // 
            this.HealthClinic.AutoSize = true;
            this.HealthClinic.BackColor = System.Drawing.Color.Transparent;
            this.HealthClinic.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.HealthClinic.Location = new System.Drawing.Point(60, 50);
            this.HealthClinic.Name = "HealthClinic";
            this.HealthClinic.Size = new System.Drawing.Size(287, 60);
            this.HealthClinic.TabIndex = 6;
            this.HealthClinic.Text = "Health clinic";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogOut.Location = new System.Drawing.Point(835, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(105, 40);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackgroundImage = global::HealthClinic.Properties.Resources.check_clocking;
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSchedule.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnSchedule.Location = new System.Drawing.Point(-3, 186);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnSchedule.Size = new System.Drawing.Size(948, 250);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Check appointments\' schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnNoticeBoard
            // 
            this.btnNoticeBoard.BackgroundImage = global::HealthClinic.Properties.Resources.notice_board;
            this.btnNoticeBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNoticeBoard.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold);
            this.btnNoticeBoard.Location = new System.Drawing.Point(0, 433);
            this.btnNoticeBoard.Name = "btnNoticeBoard";
            this.btnNoticeBoard.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.btnNoticeBoard.Size = new System.Drawing.Size(948, 250);
            this.btnNoticeBoard.TabIndex = 3;
            this.btnNoticeBoard.Text = "Check notice board";
            this.btnNoticeBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoticeBoard.UseVisualStyleBackColor = true;
            this.btnNoticeBoard.Click += new System.EventHandler(this.btnNoticeBoard_Click);
            // 
            // MedicalPersonnelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelMedicalPersonnel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "MedicalPersonnelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome, !";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MedicalPersonnelForm_FormClosed);
            this.Load += new System.EventHandler(this.MedicalPersonnelForm_Load);
            this.panelMedicalPersonnel.ResumeLayout(false);
            this.panelMedicalPersonnel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMedicalPersonnel;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnNoticeBoard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label HealthClinic;
    }
}