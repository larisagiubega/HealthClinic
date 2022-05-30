namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    public interface IMedicinePresenter
    {
        List<MedicineDto> GetAllMedicine();
    }
}
