using System;
using System.Text.RegularExpressions;

namespace Lab_7_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPlease enter a valid name: ");
            string name = Console.ReadLine();

            if (ValidateName(name))
            {
                Console.WriteLine(name + " is a valid name");
            } else
            {
                Console.WriteLine(name + " is NOT a valid name");
            }

            Console.Write("\nPlease enter a valid email address: ");
            string emailAddress = Console.ReadLine();

            if (ValidateEmailAddr(emailAddress))
            {
                Console.WriteLine(emailAddress + " is a valid email address");
            }
            else
            {
                Console.WriteLine(emailAddress + " is NOT a valid email address");
            }

            Console.Write("\nPlease enter a valid phone number: ");
            string phoneNumber = Console.ReadLine();

            if (ValidatePhoneNumber(phoneNumber))
            {
                Console.WriteLine(phoneNumber + " is a valid phone number");
            }
            else
            {
                Console.WriteLine(phoneNumber + " is NOT a valid phone number");
            }

            Console.Write("\nPlease enter a valid date (dd/mm/yyyy): ");
            string dateString = Console.ReadLine();

            if (ValidateDate(dateString))
            {
                Console.WriteLine(dateString + " is a valid date");
            }
            else
            {
                Console.WriteLine(dateString + " is NOT a valid date");
            }

            Console.Write("\nPlease enter valid HTML: ");
            string htmlString = Console.ReadLine();

            if (ValidateHTML(htmlString))
            {
                Console.WriteLine(htmlString + " is valid HTML.");
            }
            else
            {
                Console.WriteLine(htmlString + " is NOT valid HTML");
            }

            Main(args);
        }
        static bool ValidateName(string name)
        {
            if (Regex.IsMatch(name, "([A-Z]+[A-z]{0,30})"))
                return true;
            else
                return false;
        }

        static bool ValidateEmailAddr(string emailAddr)
        {
            if (Regex.IsMatch(emailAddr, "([A-z0-9]{5,30}@[A-z0-9]{5,10}.[A-z0-9]{2,3})"))
                return true;
            else
                return false;
        }

        static bool ValidatePhoneNumber(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, "([0-9]{3}-[0-9]{3}-[0-9]{4})"))
                return true;
            else
                return false;
        }

        static bool ValidateDate(string dateString)
        {
            if (Regex.IsMatch(dateString, "([0-2][0-9]|[3]([0]|[1]))/([1-2][0-9])/([0-9]){4}"))
                return true;
            else
                return false;
        }

        static bool ValidateHTML(string htmlString)
        {
            if (Regex.IsMatch(htmlString, "<([A-z])>[A-z0-9 ]*</\\1>"))
                return true;
            else
                return false;
        }

    }
}
