using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace RegExTesting
{
    [TestClass]
    public class RegexTest
    {
        private static string firstNameAndLastNamePattern;
        private static string agePattern;
        private static string dobPattern;
        private static string phonePattern;
        private static bool isPatternMatched;

        [ClassInitialize]
        public static void InitializeClass(TestContext context)
        {
            firstNameAndLastNamePattern = @"^[A-Z][a-z]*$";
            agePattern = @"^\d+$";
            dobPattern = @"^(0[1-9]|1[012])[-/.](0[1-9]|[12][0-9]|3[01])[-/.](19|20)\d\d$";     // mm-dd-yyyy
            phonePattern = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
            isPatternMatched = false;
        }

        [TestMethod]
        public void TestFirstName()
        {
            string firstName = "Rohitaswa";
            isPatternMatched = Regex.IsMatch(firstName, firstNameAndLastNamePattern);
            Assert.IsTrue(isPatternMatched, "First name doesn't match with the expected pattern");
        }

        [TestMethod]
        public void TestLastName()
        {
            string lastName = "De";
            isPatternMatched = Regex.IsMatch(lastName, firstNameAndLastNamePattern);
            Assert.IsTrue(isPatternMatched, "Last name doesn't match with the expected pattern");
        }

        [TestMethod]
        public void TestAge()
        {
            int a = 33;
            string age = Convert.ToString(a);
            isPatternMatched = Regex.IsMatch(age, agePattern);
            Assert.IsTrue(isPatternMatched, "Age doesn't match with the expected pattern");
        }

        [TestMethod]
        public void TestDateOfBirth()
        {
            int day = 30;
            int month = 6;
            int year = 1988;
            string dateOfBirth = (month < 10 ? "0" : "") + Convert.ToString(month) + "/"
                + Convert.ToString(day) + "/" + Convert.ToString(year);
            isPatternMatched = Regex.IsMatch(dateOfBirth, dobPattern);
            Assert.IsTrue(isPatternMatched, "Date of birth doesn't match with the expected pattern");
        }

        [TestMethod]
        public void TestPhoneNumber()
        {
            string phone = "(508)-308-5827";
            isPatternMatched = Regex.IsMatch(phone, phonePattern);
            Assert.IsTrue(isPatternMatched, "Phone doesn't match with the expected pattern");
        }
    }
}
