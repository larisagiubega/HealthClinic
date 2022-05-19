
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

        public int GetMedicineIdByName(string name)
        {
            int medicineId;

            try
            {
                medicineId = _ctx.MEDICINE.Where(x => x.MEDICINE_NAME.ToLower().Contains(name.ToLower())).FirstOrDefault().ID_MEDICINE;
            }
            catch
            {
                medicineId = -1;
                Logger.Log(res.GetString(new GetMedicineByItsNameException().Message));
            }

            return medicineId;
        }

        public bool SaveMedicineToDatabase(MedicineDto medicine)
        {
            var success = true;

            try
            {
                if (MedicineNameExists(medicine.MedicineName))
                {
                    if (!UpdateMedicine(medicine))
                    {
                        success = false;
                    }
                }
                else
                {
                    if (!AddMedicine(medicine))
                    {
                        success = false;
                    }
                }
            }
            catch
            {
                success = false;
                Logger.Log(res.GetString(new CannotSaveMedicine().Message));
            }

            return success;
        }

        public bool AddMedicine(MedicineDto medicineDto)
        {
            bool success = false;

            try
            {
                MEDICINE medicine = new MEDICINE
                {
                    LAST_BILLING = medicineDto.LastBilling,
                    MEDICINE_NAME = medicineDto.MedicineName,
                    QUANTITY = medicineDto.Quantity
                };

                _ctx.MEDICINE.Add(medicine);
                _ctx.SaveChanges();

                success = true;
            }
            catch
            {
                Logger.Log(res.GetString(new SaveAppointmentsException().Message));
                success = false;
            }

            return success;
        }

        public bool MedicineNameExists(string medicineName)
        {
            var success = false;
            try
            {
                success = _ctx.MEDICINE.Any(x => x.MEDICINE_NAME.ToLower().Contains(medicineName.ToLower()));

            }
            catch
            {
                success = false;
                Logger.Log(res.GetString(new GetMedicineByItsNameException().Message));
            }

            return success;
        }

        public bool UpdateMedicine(MedicineDto medicine)
        {
            var success = true;

            try
            {
                var medicineToUpdate = _ctx.MEDICINE.Find(GetMedicineIdByName(medicine.MedicineName));

                if (medicineToUpdate != null)
                {
                    medicineToUpdate.QUANTITY += medicine.Quantity;
                    medicineToUpdate.LAST_BILLING = medicine.LastBilling;

                    _ctx.SaveChanges();
                }
                else
                {
                    success = false;
                }
            }
            catch
            {
                success = false;
                Logger.Log(res.GetString(new CannotUpdateMedicine().Message));
            }

            return success;
        }
    }
}
