using Microsoft.VisualStudio.TestTools.UnitTesting;
using Phonebook.Utilities;

namespace PhonebookTests
{
    [TestClass]
    public class UtilitiesTest
    {
        [TestMethod]
        public void TestEmailValidation()
        {
            //Arrange
            string email = "jhayphantom-man@yaho.co.uk";
            string email1 = "chukwuemeka@decagon.dev";
            string email2 = "bright---adams@dechq.com.ng";

            //Act
            bool validEmail = Validation.ValidateEmail(email);
            bool validEmail1 = Validation.ValidateEmail(email1);
            bool validEmail2 = Validation.ValidateEmail(email2);

            //Assert
            Assert.IsTrue(validEmail);
            Assert.IsTrue(validEmail1);
            Assert.IsFalse(validEmail2);
        }

        [TestMethod]
        public void TestPhonenumberValidation()
        {
            string phonenumber = "+2348190993394";
            string phonenumber1 = "+234803216789";
            string phonenumber2 = "02458886334560";
            string phonenumber3 = "02456ghhgfddgj";

            Assert.IsTrue(Validation.ValidatePhonenumber(phonenumber));
            Assert.IsFalse(Validation.ValidatePhonenumber(phonenumber1));
            Assert.IsFalse(Validation.ValidatePhonenumber(phonenumber2));
            Assert.IsFalse(Validation.ValidatePhonenumber(phonenumber3));
        }

        [TestMethod]

        public void TestNameValidation()
        {
            string name = "Shade";
            string name2 = "shade-";
            string name3 = "Sha7de";
            string name4 = "5shade";

            Assert.IsTrue(Validation.ValidateName(name));
            Assert.IsFalse(Validation.ValidateName(name2));
            Assert.IsFalse(Validation.ValidateName(name3));
            Assert.IsFalse(Validation.ValidateName(name4));
        }
    }
}
