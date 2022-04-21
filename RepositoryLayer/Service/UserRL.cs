using DataBaseLayer;
using RepositoryLayer.FundooNoteContex;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Service
{
    public class UserRL : IUserRL
    {
        FundooContext fundoo;
        public UserRL(FundooContext fundoo)
        {
            this.fundoo = fundoo;
        }
        public void AddUser(UserPostModel user)
        {
            try
            {
                Entity.User user1 = new Entity.User();
                user1.UserId = new Entity.User().UserId;
                user1.FirstName = user.FirstName;
                user1.LastName = user.LastName;
                user1.Email = user.Email;
                user1.Adress = user.Adress;
                user1.Password = user.Password;
                user1.registerdDate = DateTime.Now;
                fundoo.Users.Add(user1);
                fundoo.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string LoginUser(string Email, string Password)
        {
            try
            {
                var result = fundoo.Users.FirstOrDefault(u => u.Email == Email && u.Password == Password);
                if (result == null)
                {
                    return null;
                }
                return Email;
                //string Password = Password;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
