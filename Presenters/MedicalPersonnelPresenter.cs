namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    public class MedicalPersonnelPresenter : IMedicalPersonnelPresenter
    {
        private readonly IUserDal personDal;

        public MedicalPersonnelPresenter(HealthClinicEntities ctx)
        {
            personDal = new UserDal(ctx);
        }

        public string GetUserFullNameByUser(UserDto user)
        {
            return personDal.GetUserFullNameByUser(user);
        }
    }
}
