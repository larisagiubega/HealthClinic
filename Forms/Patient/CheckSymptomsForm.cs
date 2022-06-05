
namespace HealthClinic.Forms__Views_
{
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using HealthClinic.Presenters;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Resources;
    using System.Windows.Forms;
    public partial class CheckSymptomsForm : Form
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        IDiseasesSymptomsPresenter diseasesSymptomsPresenter;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        private string language = HealthClinicLocalization.GetLanguage();

        private List<DiseaseDto> allDiseases = new List<DiseaseDto>();
        private List<SymptomsDto> allSymptoms = new List<SymptomsDto>();

        private Form prevForm;

        public CheckSymptomsForm(HealthClinicEntities ctx, Form prevForm)
        {
            InitializeComponent();

            _ctx = ctx;
            diseasesSymptomsPresenter = new DiseasesSymptomsPresenter(_ctx);

            this.prevForm = prevForm;
        }

        private void ChangeControlsFont()
        {
            foreach (Control control in panelCheckSymptoms.Controls)
            {
                control.Font = new Font("Impact", control.Font.Size);
            }
        }

        private void FillTitle()
        {
            lblFormTitle.Font = new Font(this.Font.FontFamily, 13, FontStyle.Bold);
        }

        private void FillSymptomsCheckbox()
        {
            var symptomsCheckbox = cbSymptoms.Items;

            if (allSymptoms.Count > 0)
            {
                foreach (var symptom in allSymptoms)
                {
                    symptomsCheckbox.Add(res.GetString(symptom.Symptom));
                }
            }
        }

        private void btnCheckSymptoms_Click(object sender, EventArgs e)
        {
            if (cbSymptoms.CheckedItems.Count < 3)
            {
                MessageBox.Show(res.GetString("ThreeSymptomsRequired"), res.GetString("NoSymptomsChecked"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //created list of objects where the checked items in checkbox match the "translated" symptom name
                // equivalent to getting the checked checkboxes text from database
                var symptomsFromCheckbox = allSymptoms.Where(x => cbSymptoms.CheckedItems.Contains(res.GetString(x.Symptom))).ToList();

                List<string> checkedSymptoms = new List<string>();

                foreach (var symptom in symptomsFromCheckbox)
                {
                    checkedSymptoms.Add(symptom.Symptom);
                }

                string potentialDisease = GetPotentialDisease(checkedSymptoms);

                FillDisease(potentialDisease);
            }
        }

        private void FillDisease(string potentialDisease)
        {
            if (!potentialDisease.Equals("Inconclusive"))
            {
                lblDisease.Text = $"{res.GetString("PossibleDisease")} {res.GetString(potentialDisease)}. {res.GetString("PleaseMakeAnAppointment")}";
            }
            else
            {
                lblDisease.Text = res.GetString("ResultInconclusive");
            }
        }

        private string GetPotentialDisease(List<string> checkedSymptoms)
        {
            int diseaseCount = 0;
            string checkedDisease = "";

            foreach (var disease in allDiseases)
            {
                var intersectedSymptoms = checkedSymptoms.Intersect(disease.Symptoms.Select(x => x.Symptom).ToList()).ToList();

                if (intersectedSymptoms.Count > diseaseCount)
                {
                    checkedDisease = disease.Disease;
                    diseaseCount = intersectedSymptoms.Count;
                }
            }

            if (diseaseCount < 2)
            {
                checkedDisease = "Inconclusive";
            }

            return checkedDisease;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            prevForm.Show();
        }

        private void CheckSymptomsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CheckSymptomsForm_Load(object sender, EventArgs e)
        {
            this.Text = res.GetString("HealthClinic");

            ChangeControlsFont();

            FillTitle();

            allSymptoms = diseasesSymptomsPresenter.OrderSymptomsByName();
            allDiseases = diseasesSymptomsPresenter.GetAllDiseases();

            HealthClinicLocalization.FillControlsByLanguage(res, language, panelCheckSymptoms);
            FillSymptomsCheckbox();
        }
    }
}
