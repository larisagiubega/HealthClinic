namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;

    public interface IMedicineDal
    {
        List<MedicineDto> GetAllMedicine();
    }
}
