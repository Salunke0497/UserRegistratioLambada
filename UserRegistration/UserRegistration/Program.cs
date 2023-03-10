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
            Console.ReadLine();
        }
    }
}
