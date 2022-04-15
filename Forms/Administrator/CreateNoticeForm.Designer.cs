
namespace HealthClinic.Forms.Administrator
{
    partial class CreateNoticeForm
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
            this.panelCreateNotice = new System.Windows.Forms.Panel();
            this.btnDeleteNotice = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNotice = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.panelCreateNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateNotice
            // 
            this.panelCreateNotice.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelCreateNotice.Controls.Add(this.HealthClinic);
            this.panelCreateNotice.Controls.Add(this.btnDeleteNotice);
            this.panelCreateNotice.Controls.Add(this.btnSave);
            this.panelCreateNotice.Controls.Add(this.tbNotice);
            this.panelCreateNotice.Controls.Add(this.btnBack);
            this.panelCreateNotice.Font = new System.Drawing.Font("Impact", 12F);
            this.panelCreateNotice.Location = new System.Drawing.Point(0, 0);
            this.panelCreateNotice.Name = "panelCreateNotice";
            this.panelCreateNotice.Size = new System.Drawing.Size(945, 680);
            this.panelCreateNotice.TabIndex = 0;
            // 
            // btnDeleteNotice
            // 
            this.btnDeleteNotice.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteNotice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteNotice.Font = new System.Drawing.Font("Impact", 12F);
            this.btnDeleteNotice.Location = new System.Drawing.Point(702, 629);
            this.btnDeleteNotice.Name = "btnDeleteNotice";
            this.btnDeleteNotice.Size = new System.Drawing.Size(105, 48);
            this.btnDeleteNotice.TabIndex = 3;
            this.btnDeleteNotice.Text = "Delete notice";
            this.btnDeleteNotice.UseVisualStyleBackColor = false;
            this.btnDeleteNotice.Click += new System.EventHandler(this.btnDeleteNotice_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Impact", 12F);
            this.btnSave.Location = new System.Drawing.Point(813, 629);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 48);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbNotice
            // 
            this.tbNotice.BackColor = System.Drawing.Color.White;
            this.tbNotice.Location = new System.Drawing.Point(62, 133);
            this.tbNotice.Multiline = true;
            this.tbNotice.Name = "tbNotice";
            this.tbNotice.Size = new System.Drawing.Size(856, 490);
            this.tbNotice.TabIndex = 1;
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
            // CreateNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelCreateNotice);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "CreateNoticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateNoticeForm";
            this.Load += new System.EventHandler(this.CreateNoticeForm_Load);
            this.panelCreateNotice.ResumeLayout(false);
            this.panelCreateNotice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateNotice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbNotice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteNotice;
        private System.Windows.Forms.Label HealthClinic;
    }
}