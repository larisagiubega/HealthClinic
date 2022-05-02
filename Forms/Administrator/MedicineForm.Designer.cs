
namespace HealthClinic.Forms__Views_.Administrator
{
    partial class MedicineForm
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
            this.listMedications = new System.Windows.Forms.ListView();
            this.HealthClinic = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMedicine = new System.Windows.Forms.Panel();
            this.btnProcessMedications = new System.Windows.Forms.Button();
            this.lblInsufficientStock = new System.Windows.Forms.Label();
            this.panelMedicine.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMedications
            // 
            this.listMedications.BackColor = System.Drawing.Color.White;
            this.listMedications.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMedications.HideSelection = false;
            this.listMedications.Location = new System.Drawing.Point(103, 165);
            this.listMedications.Name = "listMedications";
            this.listMedications.Size = new System.Drawing.Size(820, 504);
            this.listMedications.TabIndex = 0;
            this.listMedications.UseCompatibleStateImageBehavior = false;
            this.listMedications.View = System.Windows.Forms.View.Details;
            // 
            // HealthClinic
            // 
            this.HealthClinic.AutoSize = true;
            this.HealthClinic.BackColor = System.Drawing.Color.Transparent;
            this.HealthClinic.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold);
            this.HealthClinic.Location = new System.Drawing.Point(93, 47);
            this.HealthClinic.Name = "HealthClinic";
            this.HealthClinic.Size = new System.Drawing.Size(287, 60);
            this.HealthClinic.TabIndex = 15;
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
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelMedicine
            // 
            this.panelMedicine.BackgroundImage = global::HealthClinic.Properties.Resources.background_logo_up;
            this.panelMedicine.Controls.Add(this.lblInsufficientStock);
            this.panelMedicine.Controls.Add(this.btnProcessMedications);
            this.panelMedicine.Controls.Add(this.HealthClinic);
            this.panelMedicine.Controls.Add(this.btnBack);
            this.panelMedicine.Controls.Add(this.listMedications);
            this.panelMedicine.Location = new System.Drawing.Point(0, 0);
            this.panelMedicine.Name = "panelMedicine";
            this.panelMedicine.Size = new System.Drawing.Size(945, 680);
            this.panelMedicine.TabIndex = 17;
            // 
            // btnProcessMedications
            // 
            this.btnProcessMedications.BackColor = System.Drawing.Color.Transparent;
            this.btnProcessMedications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProcessMedications.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProcessMedications.Font = new System.Drawing.Font("Impact", 12F);
            this.btnProcessMedications.Location = new System.Drawing.Point(798, 107);
            this.btnProcessMedications.Name = "btnProcessMedications";
            this.btnProcessMedications.Size = new System.Drawing.Size(125, 52);
            this.btnProcessMedications.TabIndex = 17;
            this.btnProcessMedications.Text = "Process medications";
            this.btnProcessMedications.UseVisualStyleBackColor = false;
            // 
            // lblInsufficientStock
            // 
            this.lblInsufficientStock.AutoSize = true;
            this.lblInsufficientStock.BackColor = System.Drawing.Color.Transparent;
            this.lblInsufficientStock.Font = new System.Drawing.Font("Impact", 12F);
            this.lblInsufficientStock.Location = new System.Drawing.Point(101, 141);
            this.lblInsufficientStock.Name = "lblInsufficientStock";
            this.lblInsufficientStock.Size = new System.Drawing.Size(288, 20);
            this.lblInsufficientStock.TabIndex = 18;
            this.lblInsufficientStock.Text = "* Red background means insufficient stock";
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panelMedicine);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(960, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineForm";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            this.panelMedicine.ResumeLayout(false);
            this.panelMedicine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMedications;
        private System.Windows.Forms.Label HealthClinic;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelMedicine;
        private System.Windows.Forms.Button btnProcessMedications;
        private System.Windows.Forms.Label lblInsufficientStock;
    }
}