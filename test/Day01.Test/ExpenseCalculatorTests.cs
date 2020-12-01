using System;
using System.Linq;
using NUnit.Framework;

namespace Day01.Test
{
    public class ExpenseCalculatorTests
    {
        [Test]
        public void LocateTest()
        {
            // Arrange
            var expenseReport = @"
                1721
                979
                366
                299
                675
                1456
            ";

            var expenses = expenseReport
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            
            var expenseCalculator = new ExpenseCalculator();
            
            // Act
            var locatedEntries = expenseCalculator.Locate(expenses);
            var multiply = locatedEntries.Item1 * locatedEntries.Item2;
            
            // Assert
            Assert.That(multiply, Is.EqualTo(514579));
        }
    }
}