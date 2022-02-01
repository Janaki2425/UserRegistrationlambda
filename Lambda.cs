using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationLambda
{
    internal class Lambda
    {
        public static void Main(string[] args)
        {
            static void Check_Firstname_valid(string firstname)
            {
                if (firstname.Any(e => e.firstname = $"^[A-Z]{{1}}[a-z]{{2}}$"))
                {
                    Console.WriteLine("Valid first name");
                }
                else
                {
                    Console.WriteLine("Invalid first name");
                }
            }
            static void Check_lastname_valid(string lastname)
            {
                if (lastname.Any(e => e.lastname = "^[A-Z]{1}[a-z]{2}$"))
                {
                    Console.WriteLine("Valid last name");
                }
                else
                {
                    Console.WriteLine("Invalid last name");
                }
            }
            static void Check_Email_valid(string email)
            {
                if (email.Any(e => e.email = "^[a-z]{3}[.]{1}[a-z]?{3}[@]{1}[a-z]{2}[.]{1}[co]{1}[.]?{1}[in]?{2}$"))
                {
                    Console.WriteLine("Valid email");
                }
                else
                {
                    Console.WriteLine("Invalid email");
                }
            }
            static void Check_Mobile_Number(string mobileno)
            {
                if (mobileno.Any(e => e.mobileno = "^[1-9]{2}[' ']*[1-9]{1}[0-9]{9}$"))
                {
                    Console.WriteLine("Valid Mobile number");
                }
                else
                {
                    Console.WriteLine("Invalid Mobile number");
                }
            }
            static void Check_Password_valid(string password)
            {
                if (password.Any(e => e.password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]{1}).{7}$"))
                {
                    Console.WriteLine("Valid Password");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }
            }
        }
    }
}

