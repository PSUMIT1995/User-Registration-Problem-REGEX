using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex User Registration Problem");
            Console.WriteLine("Enter Phone Number");

            string inStr = Console.ReadLine();
            string firsName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
            string lastName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";
            string emailId = @"^[a-zA-Z0-9]+[._+-]{0,1}[a-zA-Z0-9]@[a-zA-Z0-9]{1,10}.[a-zA-Z]{2,10}[.][a-zA-Z]"; 
            string phoneNum = @"^([0-9]{2})\s([6-9]{1}[0-9]{9})$";//creating pattern for phone number
            
            Regex regex = new Regex(phoneNum);
            Console.WriteLine(regex.IsMatch(inStr));
        }
    }
}
