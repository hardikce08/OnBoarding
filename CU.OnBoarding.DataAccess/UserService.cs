﻿using CU.OnBoarding.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using EF = CU.OnBoarding.Model;

namespace CU.OnBoarding.DataAccess
{
    public class UserService : ConnectionHelper
    {
        EF.OnBoardingEntities db = null;
        public UserService()
        {
            db = new EF.OnBoardingEntities(EntityConnectionString);
        }
        public UserService(ObjectContext context)
        {
            db = context as EF.OnBoardingEntities;
        }
        public ObjectContext DbContext
        {
            get
            {
                return db as ObjectContext;
            }
        }

        public IQueryable<User> Users
        {
            get
            {
                return from r in db.Users
                       select new User
                       {
                           UserID = r.UserID,
                           EmailAddress = r.EmailAddress,
                           Password = r.Password,
                           FirstName = r.FirstName,
                           LastName = r.LastName,
                           ContactNumber = r.ContactNumber,
                           ImageName = r.ImageName,
                           CompanyId = r.CompanyId,
                       };
            }
        }
        public User UserProfileByUserId(string UserName)
        {

            var lst = (from r in db.Users
                       where r.EmailAddress == UserName
                       select new User
                       {
                           UserID = r.UserID,
                           EmailAddress = r.EmailAddress,
                           Password = r.Password,
                           FirstName = r.FirstName,
                           LastName = r.LastName,
                           ContactNumber = r.ContactNumber,
                           ImageName = r.ImageName,
                           CompanyId = r.CompanyId,
                       }).FirstOrDefault();

            return lst;

        }
        public User CheckLoginUser(string UserName, string Password)
        {

            var lst = (from r in db.Users
                       where r.EmailAddress == UserName && r.Password == Password
                       select new User
                       {
                           UserID = r.UserID,
                           EmailAddress = r.EmailAddress,
                           Password = r.Password,
                           FirstName = r.FirstName,
                           LastName = r.LastName,
                           ContactNumber = r.ContactNumber,
                           ImageName = r.ImageName,
                           CompanyId = r.CompanyId,
                       }).FirstOrDefault();

            return lst;

        }
        public User CheckAdminLoginUser(string UserName, string Password)
        {

            var lst = (from r in db.Users
                       where r.EmailAddress == UserName && r.Password == Password && r.IsSuperAdmin == true

                       select new User
                       {
                           UserID = r.UserID,
                           EmailAddress = r.EmailAddress,
                           Password = r.Password,
                           FirstName = r.FirstName,
                           LastName = r.LastName,
                           ContactNumber = r.ContactNumber,
                           ImageName = r.ImageName,
                           CompanyId = r.CompanyId,
                       }).FirstOrDefault();

            return lst;

        }
        public User UserProfileByUserId(int Id)
        {

            var lst = (from r in db.Users
                       where r.UserID == Id
                       select new User
                       {
                           UserID = r.UserID,
                           EmailAddress = r.EmailAddress,
                           Password = r.Password,
                           FirstName = r.FirstName,
                           LastName = r.LastName,
                           ContactNumber = r.ContactNumber,
                           ImageName = r.ImageName,
                           CompanyId = r.CompanyId,
                       }).FirstOrDefault();

            return lst;

        }
        public UserProfileEditModel GetEditUser(int Id)
        {

            var lst = (from r in db.Users
                       where r.UserID == Id
                       select new UserProfileEditModel
                       {
                           UserID = r.UserID,
                           EmailAddress = r.EmailAddress,
                           FirstName = r.FirstName,
                           LastName = r.LastName,
                           ContactNumber = r.ContactNumber,
                       }).FirstOrDefault();

            return lst;

        }
        public void User_InsertOrUpdate(User r)
        {
            if (r.UserID == 0)
            {
                var i = new EF.User
                {
                    EmailAddress = r.EmailAddress,
                    Password = Encryptdata(r.Password),
                    FirstName = r.FirstName,
                    LastName = r.LastName,
                    ContactNumber = r.ContactNumber,
                    ImageName = r.ImageName,
                    CompanyId = r.CompanyId,
                };

                db.Users.AddObject(i);
                db.SaveChanges();
                r.UserID = i.UserID;
            }
            else
            {
                var u = db.Users.Where(p => p.UserID == r.UserID).Single();
                u.EmailAddress = r.EmailAddress;
                //u.Password = r.Password;
                u.FirstName = r.FirstName;
                u.LastName = r.LastName;
                u.ContactNumber = r.ContactNumber;
                //u.ImageName = r.ImageName;
                //u.CompanyId = r.CompanyId;
                db.SaveChanges();
            }
        }
        public void UpdateUserProfileData(User r)
        {
            var u = db.Users.Where(p => p.UserID == r.UserID).Single();
            u.FirstName = r.FirstName;
            u.LastName = r.LastName;
            u.ContactNumber = r.ContactNumber;
            db.SaveChanges();
        }
        public void UpdateNewPassword(int UserId, string NewPassword)
        {
            var u = db.Users.Where(p => p.UserID == UserId).Single();
            u.Password = Encryptdata(NewPassword);
            db.SaveChanges();
        }
        public bool IsValidOldPassword(int UserId, string OldPassword)
        {
            string password = Encryptdata(OldPassword);
            var u = db.Users.Where(p => p.UserID == UserId && p.Password == password).FirstOrDefault();
            if (u != null)
                return true;
            else
                return false;
        }
        public List<User> AllUsers
        {
            get
            {
                return (from r in db.Users
                        select new User
                        {
                            UserID = r.UserID,
                            EmailAddress = r.EmailAddress,
                            Password = r.Password,
                            FirstName = r.FirstName,
                            LastName = r.LastName,
                            ContactNumber = r.ContactNumber,
                            ImageName = r.ImageName,
                            CompanyId = r.CompanyId,
                        }).ToList();
            }
        }
        public EF.User GetUser(int UserId)
        {
            return db.Users.Where(p => p.UserID == UserId).FirstOrDefault();
        }
        public static string Encryptdata(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }
        public static string Decryptdata(string encryptpwd)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encryptpwd);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }

    }
}
