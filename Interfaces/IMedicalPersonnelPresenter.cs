namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    public interface IMedicalPersonnelPresenter
    {
        string GetUserFullNameByUser(UserDto user);
    }
}
