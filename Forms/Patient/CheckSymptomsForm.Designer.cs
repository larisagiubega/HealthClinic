
namespace HealthClinic.Forms__Views_
{
    partial class CheckSymptomsForm
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
            this.panelCheckSymptoms = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDisease = new System.Windows.Forms.Label();
            this.lblSymptomsWarning = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnCheckSymptoms = new System.Windows.Forms.Button();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.cbSymptoms = new System.Windows.Forms.CheckedListBox();
            this.panelCheckSymptoms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCheckSymptoms
            // 
            this.panelCheckSymptoms.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelCheckSymptoms.Controls.Add(this.HealthClinic);
            this.panelCheckSymptoms.Controls.Add(this.btnBack);
            this.panelCheckSymptoms.Controls.Add(this.lblDisease);
            this.panelCheckSymptoms.Controls.Add(this.lblSymptomsWarning);
            this.panelCheckSymptoms.Controls.Add(this.lblFormTitle);
            this.panelCheckSymptoms.Controls.Add(this.cbSymptoms);
            this.panelCheckSymptoms.Controls.Add(this.btnCheckSymptoms);
            this.panelCheckSymptoms.Location = new System.Drawing.Point(0, 0);
            this.panelCheckSymptoms.Name = "panelCheckSymptoms";
            this.panelCheckSymptoms.Size = new System.Drawing.Size(945, 680);
            this.panelCheckSymptoms.TabIndex = 0;
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
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDisease
            // 
            this.lblDisease.AutoSize = true;
            this.lblDisease.BackColor = System.Drawing.Color.Transparent;
            this.lblDisease.Font = new System.Drawing.Font("Impact", 12F);
            this.lblDisease.Location = new System.Drawing.Point(49, 647);
            this.lblDisease.Name = "lblDisease";
            this.lblDisease.Size = new System.Drawing.Size(169, 20);
            this.lblDisease.TabIndex = 4;
            this.lblDisease.Text = "Here comes the disease.";
            // 
            // lblSymptomsWarning
            // 
            this.lblSymptomsWarning.AutoSize = true;
            this.lblSymptomsWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblSymptomsWarning.Font = new System.Drawing.Font("Impact", 12F);
            this.lblSymptomsWarning.Location = new System.Drawing.Point(50, 620);
            this.lblSymptomsWarning.Name = "lblSymptomsWarning";
            this.lblSymptomsWarning.Size = new System.Drawing.Size(169, 20);
            this.lblSymptomsWarning.TabIndex = 3;
            this.lblSymptomsWarning.Text = "Here comes the warning.";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Impact", 12F);
            this.lblFormTitle.Location = new System.Drawing.Point(66, 110);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(146, 20);
            this.lblFormTitle.TabIndex = 2;
            this.lblFormTitle.Text = " Here comes the title.";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckSymptoms
            // 
            this.btnCheckSymptoms.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckSymptoms.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckSymptoms.Font = new System.Drawing.Font("Impact", 12F);
            this.btnCheckSymptoms.Location = new System.Drawing.Point(827, 618);
            this.btnCheckSymptoms.Name = "btnCheckSymptoms";
            this.btnCheckSymptoms.Size = new System.Drawing.Size(105, 49);
            this.btnCheckSymptoms.TabIndex = 0;
            this.btnCheckSymptoms.Text = "Check symptoms";
            this.btnCheckSymptoms.UseVisualStyleBackColor = false;
            this.btnCheckSymptoms.Click += new System.EventHandler(this.btnCheckSymptoms_Click);
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
            // cbSymptoms
            // 
            this.cbSymptoms.BackColor = System.Drawing.Color.White;
            this.cbSymptoms.Font = new System.Drawing.Font("Impact", 12F);
            this.cbSymptoms.FormattingEnabled = true;
            this.cbSymptoms.Location = new System.Drawing.Point(50, 133);
            this.cbSymptoms.Name = "cbSymptoms";
            this.cbSymptoms.Size = new System.Drawing.Size(856, 466);
            this.cbSymptoms.TabIndex = 1;
            // 
            // CheckSymptomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelCheckSymptoms);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "CheckSymptomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symptom checker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CheckSymptomsForm_FormClosed);
            this.Load += new System.EventHandler(this.CheckSymptomsForm_Load);
            this.panelCheckSymptoms.ResumeLayout(false);
            this.panelCheckSymptoms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCheckSymptoms;
        private System.Windows.Forms.Button btnCheckSymptoms;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblSymptomsWarning;
        private System.Windows.Forms.Label lblDisease;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label HealthClinic;
        private System.Windows.Forms.CheckedListBox cbSymptoms;
    }
}