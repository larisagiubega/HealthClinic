
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    public interface IDiseasesSymptomsPresenter
    {
        List<DiseaseDto> GetAllDiseases();
        List<SymptomsDto> GetAllSymptoms();
        List<SymptomsDto> OrderSymptomsByName();
    }
}
