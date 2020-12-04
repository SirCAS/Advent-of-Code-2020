using NUnit.Framework;

namespace Day04.Test
{
    public class ValidationTests
    {
        [TestCase(true, "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd\nbyr:1937 iyr:2017 cid:147 hgt:183cm")]
        [TestCase(true, "hcl:#ae17e1 iyr:2013\neyr:2024\necl:brn pid:760753108 byr:1931\nhgt:179cm")]
        [TestCase(false, "iyr:2013 ecl:amb cid:350 eyr:2023 pid:028048884\nhcl:#cfa07d byr:1929")]
        [TestCase(false, "hcl:#cfa07d eyr:2025 pid:166559648\niyr:2011 ecl:brn hgt:59in")]
        public void RequriedFieldsValidationTest(bool expectedResult, string input)
        {
            // Arrange
            var passportParser = new PassportParser();

            // Act
            var validity = new RequriedFieldsValidation().IsValid(passportParser.ParsePassport(input));
            
            // Assert
            Assert.That(validity, Is.EqualTo(expectedResult));
        }
        
        [TestCase(true, "byr:2002")]
        [TestCase(false, "byr:2003")]
        [TestCase(true, "hgt:60in")]
        [TestCase(true, "hgt:190cm")]
        [TestCase(false, "hgt:190in")]
        [TestCase(false, "hgt:190")]
        [TestCase(true, "hcl:#123abc")]
        [TestCase(false, "hcl:#123abz")]
        [TestCase(false, "hcl:123abc")]
        [TestCase(true, "ecl:brn")]
        [TestCase(false, "ecl:wat")]
        [TestCase(true,  "pid:000000001")]
        [TestCase(false, "pid:0123456789")]
        public void ValidValueValidationTest(bool expectedResult, string input)
        {
            // Arrange
            var passportParser = new PassportParser();

            // Act
            var validity = new ValidValueValidation().IsValid(passportParser.ParsePassport(input));
            
            // Assert
            Assert.That(validity, Is.EqualTo(expectedResult));
        }
    }
}