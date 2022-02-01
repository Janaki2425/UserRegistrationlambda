using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationLambda
{
    internal class Exception
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Kindly fill in the below User Registration form:");
            while (true)
            {
                Console.WriteLine("Enter the Firstname:");
                string name = Console.ReadLine();
                UserRegex program = new UserRegex();
                bool value = program.validatefirstname(name);
                if (value)
                {
                    Console.WriteLine("Firstname matched!!!");
                    break;
                }
                else
                {
                   throw new Exception(Exception.ExceptionType.INVALID_FIRST_NAME , "Invalid firstname");

                }
            }

            while (true)
            {
                Console.WriteLine("Enter the Lastname:");
                string namee = Console.ReadLine();
                UserRegex user = new UserRegex();
                bool lname = user.validatelastname(namee);
                if (lname)
                {
                    Console.WriteLine("Last name matched!!!");
                    break;
                }
                else
                {
                    throw new Exception(Exception.ExceptionType.INVALID_LAST_NAME, "Invalid lastname");

                }
                while (true)
                {
                    Console.WriteLine("Enter the Email:");
                    string mail = Console.ReadLine();
                    UserRegex email = new UserRegex();
                    bool Email = email.validatelastname(mail);
                    if (Email)
                    {
                        Console.WriteLine("Email matched!!!");
                        break;
                    }
                    else
                    {
                        throw new Exception(Exception.ExceptionType.INVALID_EMAIL, "Invalid EMAIL");

                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter the Phoneno:");
                    string pno = Console.ReadLine();
                    UserRegex phonenumber = new UserRegex();
                    bool Pno = phonenumber.validatelastname(pno);
                    if (Pno)
                    {
                        Console.WriteLine("Phone number matched!!!");
                        break;
                    }
                    else
                    {
                        throw new Exception(Exception.ExceptionType.INVALID_PHONE_NUMBER, "Invalid phonenumber");
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter the Password:");
                    string pword = Console.ReadLine();
                    UserRegex password = new UserRegex();
                    bool Password = password.validatepassword(pword);
                    if (Password)
                    {
                        Console.WriteLine("Password matched!!!");
                        break;
                    }
                    else
                    {
                        throw new Exception(Exception.ExceptionType.INVALID_PASSWORD, "Invalid password");
                    }

                }
            }
        }
    }
}
