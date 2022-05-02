
namespace HealthClinic.DAL
{
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MedicineDal : IMedicineDal
    {
        HealthClinicEntities _ctx;
        public MedicineDal(HealthClinicEntities ctx)
        {
            _ctx = ctx;
        }
        public List<MedicineDto> GetAllMedicine()
        {
            List<MedicineDto> allMedicine = new List<MedicineDto>();

            try
            {
                allMedicine = _ctx.MEDICINE.Select(x => new MedicineDto
                {
                    Id = x.ID_MEDICINE,
                    LastBilling = x.LAST_BILLING,
                    MedicineName = x.MEDICINE_NAME,
                    Quantity = x.QUANTITY
                }).ToList();
            }
            catch (Exception ex)
            {
                allMedicine = null;
                Logger.Log(ex.Message);
            }

            return allMedicine;
        }
    }
}
