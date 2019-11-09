using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Enter Your Personal Information*********\n\n");
            Console.WriteLine("Enter Your First Name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            var phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Enter Your Date Of Birth (Format DD/MM/YYYY): ");
            var dateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter Your Address: ");
            var address = Console.ReadLine();

            Console.WriteLine("*********Enter Your Personal Information*********\n\n");
            Console.WriteLine("Name         : " + firstName + " " + lastName);
            Console.WriteLine("Phone Number : " + phoneNumber);
            Console.WriteLine("Email        : " + email);
            Console.WriteLine("Date of Birth: " + dateOfBirth);
            Console.WriteLine("Address      : " + address);
            Console.ReadKey();
        }
    }
}
