using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void PasswordTooShort_ReturnsFalse()
        {
            // Arrange
            var password = "A!1";

            // Act
            bool result = IsPasswordValid(password);

            // Assert
            Assert.IsFalse(result, "Password should be invalid if it is too short.");
        }

        [TestMethod]
        public void PasswordWithoutUppercase_ReturnsFalse()
        {
            // Arrange
            var password = "a!12345";

            // Act
            bool result = IsPasswordValid(password);

            // Assert
            Assert.IsFalse(result, "Password should be invalid if it lacks an uppercase letter.");
        }

        [TestMethod]
        public void PasswordWithoutDigit_ReturnsFalse()
        {
            // Arrange
            var password = "Abc!def";

            // Act
            bool result = IsPasswordValid(password);

            // Assert
            Assert.IsFalse(result, "Password should be invalid if it lacks a digit.");
        }

        [TestMethod]
        public void PasswordWithoutSpecialChar_ReturnsFalse()
        {
            // Arrange
            var password = "Abc1234";

            // Act
            bool result = IsPasswordValid(password);

            // Assert
            Assert.IsFalse(result, "Password should be invalid if it lacks a special character.");
        }

        [TestMethod]
        public void ValidPassword_ReturnsTrue()
        {
            // Arrange
            var password = "Abc!123";

            // Act
            bool result = IsPasswordValid(password);

            // Assert
            Assert.IsTrue(result, "Password should be valid when all conditions are met.");
        }

        private bool IsPasswordValid(string password)
        {
            if (password.Length < 6)
                return false;
            if (!password.Any(char.IsUpper))
                return false;
            if (!password.Any(char.IsDigit))
                return false;
            char[] specialChars = new char[] { '!', '@', '#', ',', '%', '^' };
            if (!password.Any(p => specialChars.Contains(p)))
                return false;
            return true;
        }
    }
}
