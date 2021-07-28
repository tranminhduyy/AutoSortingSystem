using AutoSortingSystem.Application.ViewModel;
using AutoSortingSystem.Application.Utilities;
using AutoSortingSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSortingSystem.Data.Entities;

namespace AutoSortingSystem.Application.Service
{
    public class UserService
    {
        private static UserService _ins;
        public static UserService Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new UserService();
                return _ins;
            }
            set
            {
                _ins = value;
            }
        }

        public short AddUser(UserVM _user)
        {
            try
            {
                var isUserExist = DataProvider.Ins.DB.Users.Where(x => x.UserName == _user.UserName).Count();
                if (isUserExist == 0)
                {
                    var newaccount = new User()
                    {
                        ID = Guid.NewGuid(),
                        UserName = _user.UserName,
                        Email = _user.Email,
                        PasswordHash = Encryptor.MD5Hash(_user.Password),
                        PhoneNumber = _user.PhoneNo,
                        FirstName = _user.FirstName,
                        LastName = _user.LastName,
                        Dob = _user.Dob,
                        Activate = false,
                    };
                    DataProvider.Ins.DB.Users.Add(newaccount);
                    DataProvider.Ins.DB.SaveChanges();
                    return 1;
                }
                else
                {
                    return 2;
                }          
            }
            catch
            {
                return 0;
            }
        }

        public string Login(string userName, string pass)
        {
            try
            {
                string passEncode = Encryptor.MD5Hash(pass);
                var accCount = DataProvider.Ins.DB.Users.Where(x => x.UserName == userName && x.PasswordHash == passEncode).Count();            
                if (accCount > 0)
                {
                    var isUserActive = DataProvider.Ins.DB.Users.Where(x => x.UserName == userName).SingleOrDefault().Activate;
                    if (isUserActive)
                    {
                        return userName;
                    }
                    else
                    {
                        return "Not active";
                    }
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }
        }

        public IEnumerable<UserListVM> GetUserList()
        {
            try
            {
                var res = DataProvider.Ins.DB.Users.Select(x => new UserListVM()
                {
                    ID = x.ID,
                    UserName = x.UserName,
                    Activate = x.Activate,
                    Role = x.Role,
                }).ToList();
                return res;
            }
            catch
            {
                return null;
            }          
        }

        public UserInfoVM GetUserInfo(string id)
        {
            try
            {
                var res = Data.DataProvider.Ins.DB.Users
                .Where(x => x.ID.ToString() == id)
                .Select(y => new UserInfoVM()
                {
                    ID = y.ID,
                    UserName = y.UserName,
                    Email = y.Email,
                    PhoneNo = y.PhoneNumber,
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                    Dob = y.Dob.HasValue ? y.Dob.Value : DateTime.Now,
                    Active = y.Activate,
                    Role = y.Role,
                }).SingleOrDefault();
                return res;
            }
            catch
            {
                return null;
            }
        }

        public bool UpdateUserInfo(UserInfoVM userInfo)
        {
            try
            {
                var user = DataProvider.Ins.DB.Users.Where(x => x.ID == userInfo.ID).SingleOrDefault();
                //update
                user.UserName = userInfo.UserName;
                user.Email = userInfo.Email;
                user.PhoneNumber = userInfo.PhoneNo;
                user.FirstName = userInfo.FirstName;
                user.LastName = userInfo.LastName;
                user.Dob = userInfo.Dob;
                user.Activate = userInfo.Active;
                user.Role = userInfo.Role;
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(Guid id)
        {
            try
            {
                var user = DataProvider.Ins.DB.Users.Where(x => x.ID == id).SingleOrDefault();
                DataProvider.Ins.DB.Users.Remove(user);
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool NewPassword(Guid id, string newpass)
        {
            try
            {
                var passEncode = Encryptor.MD5Hash(newpass);
                var user = DataProvider.Ins.DB.Users.Where(x => x.ID == id).SingleOrDefault();
                user.PasswordHash = passEncode;
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
