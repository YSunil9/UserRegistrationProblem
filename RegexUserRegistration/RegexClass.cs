using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegexUserRegistration
{
    internal class RegexClass

    {
        public void name(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";

            if (Regex.IsMatch(name, NAME))
            {
                Console.WriteLine(name + " is a valid Name");
                return;
            }
            Console.WriteLine(name + " is a invalid Name");
            return;
        }
        public void email(string id)
        {
            const string mailId = "^[a-zA-z0-9]+[.]{0,1}[a-zA-z0-9]+([@]?)+[a-z]{1,15}[.]+(com|co)+((.in)*)$";
            if (Regex.IsMatch(id, mailId))
            {
                Console.WriteLine(id + " is a valid Email");
                return;
            }
            Console.WriteLine(id + " is a invalid Email");
            return;
        }
        public void MobileNumber(string number)
        {
            const string numberRegex = "^(91 )[6-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(number, numberRegex))
            {
                Console.WriteLine(number + " is a valid Number");
                return;
            }
            Console.WriteLine(number + " is a invalid Number");
            return;
        }
        public void Password(string password)
        {
            const string passwordRegex = "^((?=.*[A-Z])(?=.*[a-z])(?=.*[#!@$%*-])(?=.*[0-9])).{8,}$";
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine(password + " is a valid Password");
                return;
            }
            Console.WriteLine(password + " is a invalid Password");
            return;
        }
    }
}
