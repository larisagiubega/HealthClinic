
namespace HealthClinic.DAL
{
    using HealthClinic.DTOs;
    using HealthClinic.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class UserDal : IUserDal
    {
        HealthClinicEntities _ctx = new HealthClinicEntities();
        public UserDal(HealthClinicEntities ctx)
        {
            _ctx = ctx;
        }
        public List<UserDto> GetAllAccounts()
        {
            try
            {
                var accounts = _ctx.USER.Select(x => new UserDto
                {
                    Username = x.USERNAME,
                    FirstName = x.FIRST_NAME,
                    LastName = x.LAST_NAME,
                    Rights = new RightDto
                    {
                        Id = x.RIGHT.ID_RIGHT,
                        Right = x.RIGHT.RIGHT_NAME
                    },

                    Password = x.PASSWORD
                }).ToList();
                return accounts;
            }
            catch
            {
                Logger.Log("Exception");
                return new List<UserDto>();
            }
        }
        public UserDto GetUserByUsername(string username)
        {
            try
            {
                var user = _ctx.USER.Where(x => x.USERNAME.Equals(username)).Select(y => new UserDto
                {
                    FirstName = y.FIRST_NAME,
                    LastName = y.LAST_NAME,
                    Rights = new RightDto
                    {
                        Id = y.ID_RIGHT,
                        Right = y.RIGHT.RIGHT_NAME
                    },
                    Username = username,
                    Password = y.PASSWORD
                }).FirstOrDefault();

                return user;
            }
            catch
            {
                Logger.Log("Exception");
                return new UserDto();
            }
        }

        public RightDto GetRightByRightId(int rightId)
        {
            try
            {
                var rightFromDb = _ctx.RIGHT.FirstOrDefault(x => x.ID_RIGHT == rightId);

                var right = new RightDto
                {
                    Id = rightFromDb.ID_RIGHT,
                    Right = rightFromDb.RIGHT_NAME
                };

                return right;
            }
            catch
            {
                Logger.Log("Exception");
                return new RightDto();
            }
        }
        public string GetUserFullNameByUsername(string username)
        {
            try
            {
                var user = GetUserByUsername(username);

                var fullName = $"{user.FirstName} {user.LastName}";

                return fullName;
            }
            catch
            {
                Logger.Log("Exception");
                return string.Empty;
            }
        }

        public string GetUserFullNameByUser(UserDto user)
        {
            try
            {
                return $"{user.FirstName} {user.LastName}";
            }
            catch
            {
                Logger.Log("Exception");
                return string.Empty;
            }
        }

        public List<UserDto> GetAllMedicalPersonnelAccounts()
        {
            try
            {
                var medicalPersonnelAccounts = GetAllAccounts().Where(x => x.Rights.Id == Convert.ToInt32(Enums.HealthClinicEnums.Rights.MedicalPersonnel)).ToList();

                return medicalPersonnelAccounts;
            }
            catch
            {
                Logger.Log("Exception");
                return new List<UserDto>();
            }
        }

        public List<UserDto> GetAllAdminAccounts()
        {
            try
            {
                var adminAccounts = GetAllAccounts().Where(x => x.Rights.Id == Convert.ToInt32(Enums.HealthClinicEnums.Rights.Administrator)).ToList();

                return adminAccounts;
            }
            catch
            {
                Logger.Log("Exception");
                return new List<UserDto>();
            }
        }

        public UserDto GetUserByFullName(string fullName)
        {
            try
            {
                var fullNameSplit = fullName.Split(' ');

                var firstName = fullNameSplit[0].Trim();
                var lastName = fullNameSplit[1].Trim();

                var user = _ctx.USER.Where(x => x.FIRST_NAME.Equals(firstName) && x.LAST_NAME.Equals(lastName)).Select(y => new UserDto
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Username = y.USERNAME,
                    Rights = new RightDto
                    {
                        Id = y.ID_RIGHT,
                        Right = y.RIGHT.RIGHT_NAME
                    }
                }).FirstOrDefault();

                return user;
            }
            catch
            {
                Logger.Log("Exception");
                return new UserDto();
            }
        }
    }
}
