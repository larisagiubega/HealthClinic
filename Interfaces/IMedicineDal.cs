namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;

    public interface IMedicineDal
    {
        List<MedicineDto> GetAllMedicine();
        int GetMedicineIdByName(string name);
        bool SaveMedicineToDatabase(MedicineDto medicine);
        bool AddMedicine(MedicineDto medicineDto);
        bool UpdateMedicine(MedicineDto medicineDto);
        bool MedicineNameExists(string medicineName);
    }
}
