using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex User Registration Problem");
            Console.WriteLine("Enter Password");

            string inStr = Console.ReadLine();
            string firsName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
            string lastName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
            string emailId = @"^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.][a-zA-Z]"; 
            string phoneNum = @"[0-9]{2}\s+[1-9]{10}$";
            string password = @"[a-zA-Z0-9]{1}[A-Z][0-9][@#$%&*_-]+[a-zA-Z0-9]$";//creating pattern for password

            Regex regex = new Regex(password);
            Console.WriteLine(regex.IsMatch(inStr));
        }
    }
}