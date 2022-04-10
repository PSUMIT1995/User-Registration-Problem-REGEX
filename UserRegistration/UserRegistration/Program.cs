﻿using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            string inStr = Console.ReadLine();

            //Create pattern for firstname
            string firstName = @"^[A-Z]{1}[a-zA-Z]{2,9}$";

            Regex regex = new Regex(firstName);
            Console.WriteLine(regex.IsMatch(inStr)); //The IsMatch method is used to validate a string or  
                                                     //to ensure that a string conforms to a particular pattern
        }
    }
}
