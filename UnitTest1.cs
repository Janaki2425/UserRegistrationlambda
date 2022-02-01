using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace UserRegistrationLambda
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public string AnalyzeMood()
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
            [TestMethod]

            public void TestMethodHappy()
            {
            string expected = "happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in a Happy mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethodSad()

        {
            string expected = "sad";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in sad Mood");
            string actual = moodAnalyser.AnalyzeMood();
            Assert.AreEqual(expected, actual);
        }

        public string Fname = "^[A-Z]{1}[a-z]{2}$";
        [TestMethod]
        public bool validatefirstname(string firstname)
        {
            return Regex.IsMatch(firstname, Fname);
        }

        public string Lname = "^[A-Z]{1}[a-z]{2}$";
        [TestMethod]
        public bool validatelastname(string lastname)
        {
            return Regex.IsMatch(lastname, Lname);
        }
        
        public string Email = "^[a-z]{3}[.]{1}[a-z]?{3}[@]{1}[a-z]{2}[.]{1}[co]{1}[.]?{1}[in]?{2}$";
        [TestMethod]
        public bool validateemail(string email)
        {
            return Regex.IsMatch(email, Email);
        }

        public string no = "^[1-9]{2}[' ']*[1-9]{1}[0-9]{9}$";
        [TestMethod]
        public bool validatephoneno(string phoneno)
        {
            return Regex.IsMatch(phoneno, no);
        }

        public string password = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]{1}).{7}$";
        [TestMethod]
        public bool validatepassword(string Password)
        {
            return Regex.IsMatch(Password, password);
        }
        
    }
    }
