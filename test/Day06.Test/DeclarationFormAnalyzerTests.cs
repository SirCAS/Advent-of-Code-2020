using NUnit.Framework;

namespace Day06.Test
{
    public class DeclarationFormAnalyzerTests
    {
        [Test]
        public void CountSumWithOneYesTest()
        {
            // Arrange
            var input = @"abc

a
b
c

ab
ac

a
a
a
a

b";

            var analyzer = new DeclarationFormAnalyzer();
            
            // Act
            var groupSum = analyzer.CountSumWithOneYes(input);

            // Assert
            Assert.That(groupSum, Is.EqualTo(11));
        }
        
        [Test]
        public void CountSumWithAllYesTest()
        {
            // Arrange
            var input = @"abc

a
b
c

ab
ac

a
a
a
a

b";

            var analyzer = new DeclarationFormAnalyzer();
            
            // Act
            var groupSum = analyzer.CountSumWithAllYes(input);

            // Assert
            Assert.That(groupSum, Is.EqualTo(6));
        }
    }
}