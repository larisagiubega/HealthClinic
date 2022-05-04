
namespace HealthClinic.DAL
{
    using HealthClinic.DTOs;
    using HealthClinic.Exceptions;
    using HealthClinic.Interfaces;
    using HealthClinic.Localization;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Resources;

    public class MedicineDal : IMedicineDal
    {
        HealthClinicEntities _ctx;

        private ResourceManager res = HealthClinicLocalization.GetResourceManager();

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
            catch
            {
                allMedicine = null;
                Logger.Log(res.GetString(new GetAllMedicineException().Message));
            }

            return allMedicine;
        }
    }
}
