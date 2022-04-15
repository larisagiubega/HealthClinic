
namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using System.Collections.Generic;
    public class DiseasesSymptomsPresenter : IDiseasesSymptomsPresenter
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private readonly ISymptomsDal symptomsDal;

        public DiseasesSymptomsPresenter(HealthClinicEntities ctx)
        {
            _ctx = ctx;

            symptomsDal = new SymptomsDal(_ctx);

        }

        public List<DiseaseDto> GetAllDiseases()
        {
            return symptomsDal.GetAllDiseases();
        }

        public List<SymptomsDto> GetAllSymptoms()
        {
            return symptomsDal.GetAllSymptoms();
        }

        public List<SymptomsDto> OrderSymptomsByName()
        {
            var allSymptoms = GetAllSymptoms();

            return symptomsDal.OrderSymptomsByName(allSymptoms);

        }
    }
}
