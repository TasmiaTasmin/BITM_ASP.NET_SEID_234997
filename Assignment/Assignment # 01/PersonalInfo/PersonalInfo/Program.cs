using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Enter Your Personal Information*********\n\n");
            Console.WriteLine("Enter Your First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Your Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Your Date Of Birth (Format DD/MM/YYYY): ");
            string dateOfBirth = Console.ReadLine();           
            Console.WriteLine("Enter Your Address: ");
            string address = Console.ReadLine();

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
