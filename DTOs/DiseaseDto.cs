
namespace HealthClinic.DTOs
{
    using System.Collections.Generic;
    public class DiseaseDto
    {
        public int DiseaseId { get; set; }
        public string Disease { get; set; }

        public List<SymptomsDto> Symptoms { get; set; }
    }
}
