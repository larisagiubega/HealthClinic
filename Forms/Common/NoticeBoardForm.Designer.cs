
namespace HealthClinic.Forms
{
    partial class NoticeBoardForm
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
            this.panelNoticeBoard = new System.Windows.Forms.Panel();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.rtbNotices = new System.Windows.Forms.RichTextBox();
            this.panelNoticeBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNoticeBoard
            // 
            this.panelNoticeBoard.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelNoticeBoard.Controls.Add(this.HealthClinic);
            this.panelNoticeBoard.Controls.Add(this.btnBack);
            this.panelNoticeBoard.Controls.Add(this.rtbNotices);
            this.panelNoticeBoard.Location = new System.Drawing.Point(0, 0);
            this.panelNoticeBoard.Name = "panelNoticeBoard";
            this.panelNoticeBoard.Size = new System.Drawing.Size(945, 680);
            this.panelNoticeBoard.TabIndex = 1;
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
            this.btnBack.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtbNotices
            // 
            this.rtbNotices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotices.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbNotices.Location = new System.Drawing.Point(70, 135);
            this.rtbNotices.Name = "rtbNotices";
            this.rtbNotices.ReadOnly = true;
            this.rtbNotices.Size = new System.Drawing.Size(856, 534);
            this.rtbNotices.TabIndex = 0;
            this.rtbNotices.Text = "";
            // 
            // NoticeBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelNoticeBoard);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "NoticeBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notice board";
            this.Load += new System.EventHandler(this.NoticeBoardForm_Load);
            this.panelNoticeBoard.ResumeLayout(false);
            this.panelNoticeBoard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelNoticeBoard;
        private System.Windows.Forms.RichTextBox rtbNotices;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label HealthClinic;
    }
}