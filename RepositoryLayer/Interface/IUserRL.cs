using System;
using System.Collections.Generic;
using System.Text;
using DataBaseLayer;


namespace RepositoryLayer.Interface
{
    public interface IUserRL
    {
        public void AddUser(UserPostModel user);
        public string LoginUser(string Email, string Password);
        public bool ForgetPassword(string Email);
        public bool ChangePassword(string email, string password, string confirmPassword);
        public bool DeleteUser(string email);
    }
}