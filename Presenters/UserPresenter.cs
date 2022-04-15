
namespace HealthClinic.Presenters
{
    using HealthClinic.DAL;
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public class UserPresenter : IUserPresenter
    {
        private HealthClinicEntities _ctx = new HealthClinicEntities();

        private readonly IUserDal userDal;
        public UserPresenter(HealthClinicEntities ctx)
        {
            _ctx = ctx;

            userDal = new UserDal(_ctx);
        }

        public string Decrypt(string textToDecrypt)
        {
            try
            {
                string decryptedText = "";

                string publickey = "larisa22";
                string privatekey = "giubegal";

                byte[] privatekeyByte = { };
                privatekeyByte = System.Text.Encoding.UTF8.GetBytes(privatekey);

                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);

                MemoryStream ms = null;
                CryptoStream cs = null;

                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));

                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    decryptedText = encoding.GetString(ms.ToArray());
                }
                return decryptedText;
            }
            catch
            {
                Logger.Log("Exception");
            }

            return string.Empty;
        }

        public string Encrypt(string textToEncrypt)
        {
            try
            {
                string encryptedText = "";

                string publickey = "larisa22";
                string secretkey = "giubegal";

                byte[] secretkeyByte = { };
                secretkeyByte = Encoding.UTF8.GetBytes(secretkey);

                byte[] publickeybyte = { };
                publickeybyte = Encoding.UTF8.GetBytes(publickey);

                MemoryStream ms = null;
                CryptoStream cs = null;

                byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    encryptedText = Convert.ToBase64String(ms.ToArray());
                }
                return encryptedText;
            }
            catch
            {
                Logger.Log("Exception");
            }

            return string.Empty;
        }

        public UserDto GetUserByUsername(string username)
        {
            return userDal.GetUserByUsername(username);
        }

        public List<UserDto> GetAllAccounts()
        {
            return userDal.GetAllAccounts();
        }

        public bool UsernameExists(string username)
        {
            var allAccounts = GetAllAccounts();
            return allAccounts.Exists(x => x.Username.ToLower().Contains(username));
        }
    }
}
