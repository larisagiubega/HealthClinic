
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    interface IUserDal
    {
        List<UserDto> GetAllAccounts();
        List<UserDto> GetAllMedicalPersonnelAccounts();
        List<UserDto> GetAllAdminAccounts();
        RightDto GetRightByRightId(int rightId);
        UserDto GetUserByUsername(string username);

        UserDto GetUserByFullName(string fullName);

        string GetUserFullNameByUsername(string username);

        string GetUserFullNameByUser(UserDto user);

    }
}
