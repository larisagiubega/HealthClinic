
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    interface ISymptomsDal
    {
        List<SymptomsDto> GetAllSymptoms();

        List<SymptomsDto> OrderSymptomsByName(List<SymptomsDto> symptomsList);

        List<DiseaseDto> GetAllDiseases();


    }
}
