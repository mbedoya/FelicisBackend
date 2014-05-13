using BusinessManager.Models;
using BusinessManager.Models.DAL;
using BusinessManager.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Business
{
    public static class ProfileBO
    {
        public static ProfileDataModel Get(string email, string password)
        {
            return ProfileDAL.Get(email, password);
        }

        public static ProfileDataModel Get(string email)
        {
            return ProfileDAL.Get(email);
        }

        public static ProfileDataModel Create(ProfileDataModel profile)
        {
            //Check Email, it does not exist?
            if (String.IsNullOrWhiteSpace(Get(profile.email).mongoid))
            {
                return ProfileDAL.Create(profile);
            }

            throw new AccountExistsException("Email exists already");
            
        }

    }
}
