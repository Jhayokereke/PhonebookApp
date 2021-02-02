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
            Validation validation = new Validation();
            string email = "jhayphantom-man@yaho.co.uk";
            string email1 = "chukwuemeka@decagon.dev";
            string email2 = "bright---adams@dechq.com.ng";

            //Act
            bool validEmail = validation.ValidateEmail(email);
            bool validEmail1 = validation.ValidateEmail(email1);
            bool validEmail2 = validation.ValidateEmail(email2);

            //Assert
            Assert.IsTrue(validEmail);
            Assert.IsTrue(validEmail1);
            Assert.IsFalse(validEmail2);
        }

        [TestMethod]
        public void TestPhonenumberValidation()
        {
            //Arrange
            Validation validation = new Validation();
            string phonenumber = "+2348190993394";
            string phonenumber1 = "+234803216789";
            string phonenumber2 = "02458886334560";
            string phonenumber3 = "02456ghhgfddgj";

            //Act
            //Assert
            Assert.IsTrue(validation.ValidatePhonenumber(phonenumber));
            Assert.IsFalse(validation.ValidatePhonenumber(phonenumber1));
            Assert.IsFalse(validation.ValidatePhonenumber(phonenumber2));
            Assert.IsFalse(validation.ValidatePhonenumber(phonenumber3));
        }

        [TestMethod]

        public void TestNameValidation()
        {
            Validation validation = new Validation();
            string name = "Shade";
            string name2 = "shade-";
            string name3 = "Sha7de";
            string name4 = "5shade";

            Assert.IsTrue(validation.ValidateName(name));
            Assert.IsFalse(validation.ValidateName(name2));
            Assert.IsFalse(validation.ValidateName(name3));
            Assert.IsFalse(validation.ValidateName(name4));
        }
    }
}
