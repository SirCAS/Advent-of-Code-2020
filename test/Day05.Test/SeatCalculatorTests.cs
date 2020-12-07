using NUnit.Framework;

namespace Day05.Test
{
    public class SeatCalculatorTests
    {
        [TestCase("FBFBBFFRLR", 44)]
        [TestCase("BFFFBBFRRR", 70)]
        [TestCase("FFFBBBFRRR", 14)]
        [TestCase("BBFFBBFRLL", 102)]
        public void ParseRowTest(string boardingPass, int row)
        {
            // Arrange
            var seatCalculator = new SeatCalculator();

            // Act
            var seat = seatCalculator.Find(boardingPass);

            // Assert
            Assert.That(seat.Row, Is.EqualTo(row));
        }
        
        [TestCase("BFFFBBFRRR", 7)]
        [TestCase("FFFBBBFRRR", 7)]
        [TestCase("BBFFBBFRLL", 4)]
        public void ParseColumnTest(string boardingPass, int col)
        {
            // Arrange
            var seatCalculator = new SeatCalculator();

            // Act
            var seat = seatCalculator.Find(boardingPass);

            // Assert
            Assert.That(seat.Column, Is.EqualTo(col));
        }
        
        [TestCase(70, 7, 567)]
        [TestCase(14, 7, 119)]
        [TestCase(102, 4, 820)]
        public void IdCalculationTest(int row, int col, int expectedId)
        {
            // Arrange
            // Act
            var seat = new Seat
            {
                Column = col,
                Row = row
            };

            // Assert
            Assert.That(seat.Id, Is.EqualTo(expectedId));
        }
    }
}