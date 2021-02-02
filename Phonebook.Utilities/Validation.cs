using System;
using System.Text.RegularExpressions;

namespace Phonebook.Utilities
{
    public static class Validation
    {
        public static bool ValidateEmail(string email)
        {
            Regex myRegex = new Regex(@"^(\w+)(([\w\.\-])(\w+))+@([\w\-]+)((\.(\w){2,}){1,})$");
            Match match = myRegex.Match(email); //email is checked to ensure it follows specific format using regex
            if (!match.Success)
            {
                return false;
            }
            return true;
        }

        public static bool ValidatePhonenumber(string phonenumber)
        {
            Regex myRegex = new Regex(@"^(\+)(\d){13}$");
            Match match = myRegex.Match(phonenumber); //phonenumber is checked to ensure it follows specific format using regex
            if (!match.Success)
            {
                return false;
            }
            return true;
        }

        public static bool ValidateName(string name)
        {
            Regex myRegex = new Regex(@"^[A-Z][a-z]*$");
            Match match = myRegex.Match(name); //name is checked to ensure it follows specific format using regex
            if (!match.Success)
            {
                return false;
            }
            return true;
        }

        public static bool NotEmptyOrWhitespace(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return false;
            }
            return true;
        }
    }
}
