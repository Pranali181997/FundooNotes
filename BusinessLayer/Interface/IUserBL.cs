﻿using DataBaseLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IUserBL
    {
        public void AddUser(UserPostModel user);
        public string LoginUser(string Email, string Password);
    }
}