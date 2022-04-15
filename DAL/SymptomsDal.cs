
namespace HealthClinic.DAL
{
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System.Collections.Generic;
    using System.Linq;
    using System.Resources;

    public class SymptomsDal : ISymptomsDal
    {
        private HealthClinicEntities _ctx;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();
        public SymptomsDal(HealthClinicEntities ctx)
        {
            _ctx = ctx;
        }

        #region symptoms
        public List<SymptomsDto> GetAllSymptoms()
        {
            try
            {
                var allSymptoms = _ctx.SYMPTOMS.Select(x => new SymptomsDto
                {
                    Id = x.ID_SYMPTOM,
                    Symptom = x.SYMPTOM
                }).OrderBy(y => y.Symptom).ToList();

                return allSymptoms;
            }
            catch
            {
                Logger.Log("Exception");
                return new List<SymptomsDto>();
            }
        }

        public List<SymptomsDto> OrderSymptomsByName(List<SymptomsDto> symptomsList)
        {
            try
            {
                return symptomsList.OrderBy(x => res.GetString(x.Symptom)).ToList();
            }
            catch
            {
                Logger.Log("Exception");
                return new List<SymptomsDto>();
            }

        }

        #endregion

        #region diseases
        public List<DiseaseDto> GetAllDiseases()
        {
            try
            {
                var diseasesList = _ctx.DISEASES.ToList();

                var allDiseases = diseasesList.Select(x => new DiseaseDto
                {
                    DiseaseId = x.ID_DISEASE,
                    Disease = x.DISEASE,
                    Symptoms = x.DISEASES_SYMPTOMS.Select(z => new SymptomsDto
                    {
                        Id = z.SYMPTOMS.ID_SYMPTOM,
                        Symptom = z.SYMPTOMS.SYMPTOM
                    }).ToList()
                }).ToList();

                foreach (var disease in allDiseases)
                {
                    disease.Symptoms = _ctx.DISEASES_SYMPTOMS.Where(x => x.ID_DISEASE == disease.DiseaseId).Select(x => new SymptomsDto
                    {
                        Symptom = x.SYMPTOMS.SYMPTOM
                    }).ToList();
                }

                return allDiseases;
            }
            catch
            {
                Logger.Log("Exception");
                return new List<DiseaseDto>();
            }
        }
        #endregion
    }
}
