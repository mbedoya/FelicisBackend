using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessManager.Models.Exceptions
{
    public class AccountExistsException : Exception
    {
        public AccountExistsException(string errorMessage) : base(errorMessage)
        {
            
        }
    }
}
