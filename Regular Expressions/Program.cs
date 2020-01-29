using System;
using System.Text.RegularExpressions;

namespace Regular_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name: ");
            string name = Console.ReadLine();
            Console.WriteLine(ValidateName(name));

            Console.WriteLine("================================\n");

            Console.WriteLine("Please enter an Email: ");
            string email = Console.ReadLine();
            Console.WriteLine(ValidateEmail(email));

            Console.WriteLine("================================\n");

            Console.WriteLine("Please enter a phone number: ");
            string phone = Console.ReadLine();
            Console.WriteLine(ValidatePhone(phone));

            Console.WriteLine("================================\n");

            Console.WriteLine("Please enter a date: [mm/dd/yyyy]");
            string date = Console.ReadLine();
            Console.WriteLine(ValidateDate(date));

            Console.WriteLine("================================\n");


        }

        public static string ValidateName(string name)
        {
            if (Regex.IsMatch(name, @"^[A-Z][a-z]{1,30}\w$"))

            {
                return "Thanks for the name!";
            }
            else
            {
                return "Please enter a valid name.";
            }
        }

        public static string ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, @"^([A-Za-z0-9]{5,30})@([A-Za-z0-9]{5,10}).([A-Za-z0-9]{2,3})$"))

            {
                return "Thanks for the Email!";
            }
            else
            {
                return "Please enter a valid Email.";
            }
        }

        public static string ValidatePhone(string phone)
        {
            if (Regex.IsMatch(phone, @"^[0-9]{3}-[0-9]{3}-[0-9]{4}$"))

            {
                return "Thanks for the phone number!";
            }
            else
            {
                return "Please enter a valid phone number.";
            }
        }

        public static string ValidateDate(string date)
        {
            if (Regex.IsMatch(date, @"^\d{1,2}/\d{1,2}/\d{4}$"))
            {
                return "Thanks for the date!";
            }
            else
            {
                return "Please enter a valid date.";
            }
        }
    }
}
