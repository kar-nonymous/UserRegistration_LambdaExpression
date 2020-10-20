using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserResgistration_LambdaExpression;
namespace MSTesting
{
    /// <summary>
    /// Test class for ms testing.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the name.
        /// </summary>
        [TestMethod]
        public void TestName()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.ValidateFirstName("Kartikeya");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests the email.
        /// </summary>
        [TestMethod]
        public void TestEmail()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.ValidateEmail("kartikeya.kumar@capgemini.com");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests the mobile number.
        /// </summary>
        [TestMethod]
        public void TestMobileNum()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.ValidateMobileNum("91 7206183244");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests the password.
        /// </summary>
        [TestMethod]
        public void TestPassword()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.ValidatePassword("Kartikeya@19");
            //Assert
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Tests the valid multiple email id.
        /// </summary>
        /// <param name="expected">if set to <c>true</c> [expected].</param>
        /// <param name="email">The email.</param>
        [DataTestMethod]
        [DataRow(true, "abc@yahoo.com")]
        [DataRow(true, "abc-100@yahoo.com")]
        [DataRow(true, "abc.100@yahoo.com")]
        [DataRow(true, "abc111@abc.com")]
        [DataRow(true, "abc-100@abc.net")]
        [DataRow(true, "abc.100@abc.com.au")]
        [DataRow(true, "abc+100@gmail.com")]
        public void TestValidMultiplEmail(bool expected, string email)
        {
            //Act
            bool actual = Program.ValidateEmail(email);
            //Assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
