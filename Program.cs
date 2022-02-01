using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationLambda
{

        internal class Program
        {
            public static void Main(string[] args)
            {
                UserRegex userRegex = new UserRegex();
                userRegex.AnalyzeMood();
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
                        Console.WriteLine("Invalid firstname");

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
                        Console.WriteLine("Invalid Last name");
                    }
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
                        Console.WriteLine("Invalid Email");
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
                        Console.WriteLine("Email matched!!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Email");
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
                        Console.WriteLine("Invalid Password");
                    }
                }
            }
        }
    }







