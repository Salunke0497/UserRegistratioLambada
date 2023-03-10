using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegstrationLambada lambada = new RegstrationLambada();
            lambada.CheckFirstName("Amol");
            lambada.CheckLastName("Salunke");
            lambada.CheckEmailId("abc.xyz@bl.co.in");
            lambada.CheckPhoneNumber("91 8390266064");
            lambada.CheckPasswordRule1("Amol1234");
            lambada.CheckPasswordRule2("Amol1234");
            lambada.CheckPasswordRule3("Amolsal3");
            Console.ReadLine();
        }
    }
}
