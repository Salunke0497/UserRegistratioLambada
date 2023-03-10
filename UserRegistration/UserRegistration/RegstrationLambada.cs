﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class RegstrationLambada
    {
        List<RegistrationModel> registrationModels = new List<RegistrationModel>();
        public RegstrationLambada()
        {
            RegistrationModel registration = new RegistrationModel();
            registrationModels.Add(registration);
        }
        public void CheckFirstName(string firstName)
        {
            if(registrationModels.Any(Amol=>Amol.FirstName.IsMatch(firstName)))
            {
                Console.WriteLine("It's a valid first name");
            }
            else
            {
                Console.WriteLine("It's a not valid first name");
            }
        }
    }
}
