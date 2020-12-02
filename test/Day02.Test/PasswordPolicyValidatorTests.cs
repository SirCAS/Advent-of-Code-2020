using NUnit.Framework;

namespace Day02.Test
{
    public class PasswordPolicyValidatorTests
    {
        [TestCase("1-3 a", "abcde", true)]
        [TestCase("1-3 b", "cdefg", false)]
        [TestCase("2-9 c", "ccccccccc", true)]
        public void CountValidationTest(string policy, string password, bool expectedResult)
        {
            // Arrange
            IPasswordPolicyValidator validator = new PasswordPolicyValidator();
            
            // Act
            var valid = validator.CountValidation(policy, password);
           
            // Assert
            Assert.That(valid, Is.EqualTo(expectedResult));
        }
        
        [TestCase("1-3 a", "abcde", true)]
        [TestCase("1-3 b", "cdefg", false)]
        [TestCase("2-9 c", "ccccccccc", false)]
        public void PositionValidationTest(string policy, string password, bool expectedResult)
        {
            // Arrange
            IPasswordPolicyValidator validator = new PasswordPolicyValidator();
            
            // Act
            var valid = validator.PositionValidation(policy, password);
           
            // Assert
            Assert.That(valid, Is.EqualTo(expectedResult));
        }
    }
}