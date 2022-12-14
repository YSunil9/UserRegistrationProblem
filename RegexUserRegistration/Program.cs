using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace RegexUserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome To Regex User Registration Problem");
            RegexClass code = new RegexClass();
            Console.WriteLine("1 - Enter First Name");
            Console.WriteLine("2 - Enter Last Name");
            Console.WriteLine("3 - Enter Enail-id");
            Console.WriteLine("4 - Enter Mobile Number");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    string firstName = Console.ReadLine();
                    code.name(firstName);
                    break;
                case 2:
                    Console.WriteLine("Enter Last Name");
                    string lastName = Console.ReadLine();
                    code.name(lastName);
                    break;
                case 3:
                    Console.WriteLine("Enter Enail-id");
                    string id = Console.ReadLine();
                    code.email(id);
                    break;
                case 4:
                    Console.WriteLine("Enter Mobile Number");
                    string number = Console.ReadLine();
                    code.MobileNumber(number);
                    break;
            }
        }
    }
}