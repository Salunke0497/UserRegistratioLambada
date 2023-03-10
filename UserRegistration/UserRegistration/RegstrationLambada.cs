using System;
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
        public void CheckLastName(string LastName)
        {
            if (registrationModels.Any(Amol => Amol.LastName.IsMatch(LastName)))
            {
                Console.WriteLine("It's a valid last name");
            }
            else
            {
                Console.WriteLine("It's a not valid last name");
            }
        }
        public void CheckEmailId(string EmailID)
        {
            if (registrationModels.Any(Amol => Amol.EmailID.IsMatch(EmailID)))
            {
                Console.WriteLine("It's a valid Email-Id name");
            }
            else
            {
                Console.WriteLine("It's a not valid Email-Id name");
            }
        }
        public void CheckPhoneNumber(string PhoneNumber)
        {
            if (registrationModels.Any(Amol => Amol.PhoneNumber.IsMatch(PhoneNumber)))
            {
                Console.WriteLine("It's a valid PhoneNumber");
            }
            else
            {
                Console.WriteLine("It's a not valid PhoneNumber");
            }
        }
        public void CheckPasswordRule1(string PasswordRule1)
        {
            if (registrationModels.Any(Amol => Amol.PasswordRule1.IsMatch(PasswordRule1)))
            {
                Console.WriteLine("It's a valid Password");
            }
            else
            {
                Console.WriteLine("It's a not valid Password");
            }
        }
        public void CheckPasswordRule2(string PasswordRule2)
        {
            if (registrationModels.Any(Amol => Amol.PasswordRule2.IsMatch(PasswordRule2)))
            {
                Console.WriteLine("It's a valid Password");
            }
            else
            {
                Console.WriteLine("It's a not valid Password");
            }
        }
    }
}
