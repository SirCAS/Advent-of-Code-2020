using NUnit.Framework;

namespace Day03.Test
{
    public class ScreenBufferTests
    {
        [TestCase(0,0,false)]
        [TestCase(1,0,true)]
        [TestCase(2,0,false)]
        [TestCase(3,0,true)]
        [TestCase(0,1,true)]
        [TestCase(1,1,false)]
        [TestCase(2,1,true)]
        [TestCase(3,1,false)]
        public void GetTest(int x, int y, bool expected)
        {
            // Arrange
            var input = new[]
            {
                ".#",
                "#.",
            };
            
            var screenBuffer = new ScreenBuffer(input);
            
            // Act
            var result = screenBuffer.Get(x, y);
            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}