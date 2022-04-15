
namespace HealthClinic.Forms__Views_.Administrator
{
    partial class EditNoticeForm
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
            this.panelEditNotice = new System.Windows.Forms.Panel();
            this.btnDeleteNotice = new System.Windows.Forms.Button();
            this.btnShowAllNotices = new System.Windows.Forms.Button();
            this.btnEditNotice = new System.Windows.Forms.Button();
            this.rtbNotices = new System.Windows.Forms.RichTextBox();
            this.cbNotices = new System.Windows.Forms.ComboBox();
            this.lblSelectNotice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.panelEditNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEditNotice
            // 
            this.panelEditNotice.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelEditNotice.Controls.Add(this.HealthClinic);
            this.panelEditNotice.Controls.Add(this.btnDeleteNotice);
            this.panelEditNotice.Controls.Add(this.btnShowAllNotices);
            this.panelEditNotice.Controls.Add(this.btnEditNotice);
            this.panelEditNotice.Controls.Add(this.rtbNotices);
            this.panelEditNotice.Controls.Add(this.cbNotices);
            this.panelEditNotice.Controls.Add(this.lblSelectNotice);
            this.panelEditNotice.Controls.Add(this.btnBack);
            this.panelEditNotice.Location = new System.Drawing.Point(0, 0);
            this.panelEditNotice.Name = "panelEditNotice";
            this.panelEditNotice.Size = new System.Drawing.Size(945, 680);
            this.panelEditNotice.TabIndex = 3;
            // 
            // btnDeleteNotice
            // 
            this.btnDeleteNotice.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteNotice.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteNotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteNotice.Font = new System.Drawing.Font("Impact", 12F);
            this.btnDeleteNotice.Location = new System.Drawing.Point(791, 629);
            this.btnDeleteNotice.Name = "btnDeleteNotice";
            this.btnDeleteNotice.Size = new System.Drawing.Size(105, 48);
            this.btnDeleteNotice.TabIndex = 6;
            this.btnDeleteNotice.Text = "Delete notice";
            this.btnDeleteNotice.UseVisualStyleBackColor = false;
            this.btnDeleteNotice.Visible = false;
            this.btnDeleteNotice.Click += new System.EventHandler(this.btnDeleteNotice_Click);
            // 
            // btnShowAllNotices
            // 
            this.btnShowAllNotices.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllNotices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowAllNotices.Font = new System.Drawing.Font("Impact", 12F);
            this.btnShowAllNotices.Location = new System.Drawing.Point(110, 629);
            this.btnShowAllNotices.Name = "btnShowAllNotices";
            this.btnShowAllNotices.Size = new System.Drawing.Size(148, 48);
            this.btnShowAllNotices.TabIndex = 5;
            this.btnShowAllNotices.Text = "Show all notices";
            this.btnShowAllNotices.UseVisualStyleBackColor = false;
            this.btnShowAllNotices.Click += new System.EventHandler(this.btnShowAllNotices_Click);
            // 
            // btnEditNotice
            // 
            this.btnEditNotice.BackColor = System.Drawing.Color.Transparent;
            this.btnEditNotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditNotice.Font = new System.Drawing.Font("Impact", 12F);
            this.btnEditNotice.Location = new System.Drawing.Point(680, 629);
            this.btnEditNotice.Name = "btnEditNotice";
            this.btnEditNotice.Size = new System.Drawing.Size(105, 48);
            this.btnEditNotice.TabIndex = 4;
            this.btnEditNotice.Text = "Edit notice";
            this.btnEditNotice.UseVisualStyleBackColor = false;
            this.btnEditNotice.Visible = false;
            this.btnEditNotice.Click += new System.EventHandler(this.btnEditNotice_Click);
            // 
            // rtbNotices
            // 
            this.rtbNotices.BackColor = System.Drawing.Color.White;
            this.rtbNotices.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotices.Font = new System.Drawing.Font("Impact", 12F);
            this.rtbNotices.Location = new System.Drawing.Point(110, 178);
            this.rtbNotices.Name = "rtbNotices";
            this.rtbNotices.ReadOnly = true;
            this.rtbNotices.Size = new System.Drawing.Size(786, 445);
            this.rtbNotices.TabIndex = 3;
            this.rtbNotices.Text = "";
            // 
            // cbNotices
            // 
            this.cbNotices.Font = new System.Drawing.Font("Impact", 12F);
            this.cbNotices.FormattingEnabled = true;
            this.cbNotices.Location = new System.Drawing.Point(112, 144);
            this.cbNotices.Name = "cbNotices";
            this.cbNotices.Size = new System.Drawing.Size(235, 28);
            this.cbNotices.TabIndex = 2;
            this.cbNotices.SelectionChangeCommitted += new System.EventHandler(this.cbNotices_SelectionChangeCommitted);
            // 
            // lblSelectNotice
            // 
            this.lblSelectNotice.AutoSize = true;
            this.lblSelectNotice.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectNotice.Font = new System.Drawing.Font("Impact", 12F);
            this.lblSelectNotice.Location = new System.Drawing.Point(112, 120);
            this.lblSelectNotice.Name = "lblSelectNotice";
            this.lblSelectNotice.Size = new System.Drawing.Size(94, 20);
            this.lblSelectNotice.TabIndex = 1;
            this.lblSelectNotice.Text = "Select notice";
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
            this.HealthClinic.TabIndex = 15;
            this.HealthClinic.Text = "Health clinic";
            // 
            // EditNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelEditNotice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "EditNoticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditNoticeForm";
            this.Load += new System.EventHandler(this.EditNoticeForm_Load);
            this.panelEditNotice.ResumeLayout(false);
            this.panelEditNotice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEditNotice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSelectNotice;
        private System.Windows.Forms.ComboBox cbNotices;
        private System.Windows.Forms.RichTextBox rtbNotices;
        private System.Windows.Forms.Button btnEditNotice;
        private System.Windows.Forms.Button btnShowAllNotices;
        private System.Windows.Forms.Button btnDeleteNotice;
        private System.Windows.Forms.Label HealthClinic;
    }
}