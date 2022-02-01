using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationLambda
{
    internal class UserRegex
    {
        
        public string Fname = "^[A-Z]{1}[a-z]{2}$";
        public bool validatefirstname(string firstname)
        {
            return Regex.IsMatch(firstname, Fname);
        }
        public string Lname = "^[A-Z]{1}[a-z]{2}$";
        public bool validatelastname(string lastname)
        {
            return Regex.IsMatch(lastname, Lname);
        }
        public string Email = "^[a-z]{3}[.]{1}[a-z]?{3}[@]{1}[a-z]{2}[.]{1}[co]{1}[.]?{1}[in]?{2}$";
        public bool validateemail(string email)
        {
            return Regex.IsMatch(email, Email);
        }
        public string no = "^[1-9]{2}[' ']*[1-9]{1}[0-9]{9}$";
        public bool validatephoneno(string phoneno)
        {
            return Regex.IsMatch(phoneno, no);
        }
        public string password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]{1}).{7}$";
        public bool validatepassword(string Password)
        {
            return Regex.IsMatch(Password, password);
        }
    }
}
