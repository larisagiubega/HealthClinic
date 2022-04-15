
namespace HealthClinic.Interfaces
{
    using HealthClinic.DTOs;
    using System.Collections.Generic;
    public interface IUserPresenter
    {
        string Encrypt(string textToEncrypt);
        string Decrypt(string textToDecrypt);

        UserDto GetUserByUsername(string username);
        bool UsernameExists(string username);

        List<UserDto> GetAllAccounts();
    }
}
