using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Shop_System.Models;
using Shop_System.DAL;

namespace Shop_System.BLL
{
    public class UserBLL
    {
       static public USERS ValidateUser(string userName, string password)
        {
            if (String.IsNullOrWhiteSpace(userName) || String.IsNullOrWhiteSpace(password))
                return null;

            UserDAL<USERS> userDAL = new UserDAL<USERS>();
            return userDAL.LoadEntities(x =>x.USER_NAME == userName && x.U_PASSWORD == password).FirstOrDefault();
        }
    }
}