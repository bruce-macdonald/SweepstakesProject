﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant 
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
        public int RegistrationNumber;

        public Contestant()
        {
            FirstName = UserInterface.GetUserInputFor("Please enter your first name");
            LastName = UserInterface.GetUserInputFor("Please enter your last name");
            EmailAddress = UserInterface.GetUserInputFor("Please enter your email address");
        }
    }
}
