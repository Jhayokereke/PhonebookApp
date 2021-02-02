using System;
using System.Text.RegularExpressions;

namespace Phonebook.Utilities
{
    public class Validation
    {
        public bool ValidateEmail(string email)
        {
            Regex myRegex = new Regex(@"^(\w+)(([\w\.\-])(\w+))+@([\w\-]+)((\.(\w){2,}){1,})$");
            Match match = myRegex.Match(email); //email is checked to ensure it follows specific format using regex
            if (!match.Success)
            {
                return false;
            }
            return true;
        }

        public bool ValidatePhonenumber(string phonenumber)
        {
            Regex myRegex = new Regex(@"^(\+)(\d){13}$");
            Match match = myRegex.Match(phonenumber); //phonenumber is checked to ensure it follows specific format using regex
            if (!match.Success)
            {
                return false;
            }
            return true;
        }

        public bool ValidateName(string name)
        {
            Regex myRegex = new Regex(@"^[A-Z][a-z]*$");
            Match match = myRegex.Match(name); //name is checked to ensure it follows specific format using regex
            if (!match.Success)
            {
                return false;
            }
            return true;
        }
    }
}
