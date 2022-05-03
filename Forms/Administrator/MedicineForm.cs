namespace HealthClinic.Forms__Views_.Administrator
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Resources;
    using System.Windows.Forms;

    public partial class MedicineForm : Form
    {
        private HealthClinicEntities _ctx;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        private UserDto loggedInUser = null;

        Form prevForm;

        private IMedicineDal medicineDal;

        public MedicineForm(HealthClinicEntities ctx, Form prevForm, UserDto loggedInUser)
        {
            InitializeComponent();

            _ctx = ctx;
            this.prevForm = prevForm;
            this.loggedInUser = loggedInUser;

            medicineDal = new MedicineDal(_ctx);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("MedicineForm");

            ChangeControlsFont();

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelMedicine);

            FillMedicineList();
        }

        private void FillMedicineList()
        {
            lblInsufficientStock.Visible = false;
            listMedications.Clear();

            CreateListColumns();
            CreateItemsAndFillList();
        }

        private void CreateItemsAndFillList()
        {
            ListViewItem medicineItem;

            List<string> insufficientStock = new List<string>();

            var allMedicine = medicineDal.GetAllMedicine();

            foreach (var medicine in allMedicine)
            {
                medicineItem = new ListViewItem(medicine.MedicineName);
                medicineItem.SubItems.Add(Convert.ToString(medicine.Quantity));
                medicineItem.SubItems.Add(Convert.ToString(medicine.LastBilling));

                if (medicine.Quantity <= 3)
                {
                    lblInsufficientStock.Visible = true;
                    medicineItem.BackColor = Color.Red;

                    if (medicine.Quantity == 0)
                    {
                        insufficientStock.Add(medicine.MedicineName);
                    }
                }

                listMedications.Items.Add(medicineItem);
            }

            if (insufficientStock.Count > 0 && UseEmail.CanSendEmail(DateTime.Now))
            {
                UseEmail.SendEmail($"{loggedInUser.Username}@healthclinic.com", $"{res.GetString("EmptyStock")}", $"{res.GetString("InsufficientStockFor")}\r\n{string.Join("\n", insufficientStock.ToArray())}");
            }

        }

        private void CreateListColumns()
        {
            ColumnHeader name, quantity, lastBilling;

            name = new ColumnHeader();
            name.Text = res.GetString("MedicineName");
            name.TextAlign = HorizontalAlignment.Center;
            name.Width = 250;

            quantity = new ColumnHeader();
            quantity.Text = res.GetString("Quantity");
            quantity.TextAlign = HorizontalAlignment.Center;
            quantity.Width = 250;

            lastBilling = new ColumnHeader();
            lastBilling.Text = res.GetString("LastBillingDate");
            lastBilling.TextAlign = HorizontalAlignment.Center;
            lastBilling.Width = 250;

            listMedications.Columns.AddRange(new ColumnHeader[3]
            {   name,
                quantity,
                lastBilling
            });

            listMedications.View = View.Details;
        }
        private void ChangeControlsFont()
        {
            foreach (Control control in panelMedicine.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }
    }
}
