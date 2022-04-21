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
    }
}