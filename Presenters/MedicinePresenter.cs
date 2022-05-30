namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using System.Collections.Generic;

    public class MedicinePresenter : IMedicinePresenter
    {
        private IMedicineDal medicineDal;

        public MedicinePresenter(HealthClinicEntities ctx)
        {
            medicineDal = new MedicineDal(ctx);
        }
        public List<MedicineDto> GetAllMedicine()
        {
            return medicineDal.GetAllMedicine();
        }
    }
}
