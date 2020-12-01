using System;
using System.Linq;
using NUnit.Framework;

namespace Day01.Test
{
    public class ExpenseCalculatorTests
    {
        [TestCase(241861950, 3)]
        [TestCase(514579, 2)]
        public void LocateTest(int expected, int matchesToFind)
        {
            // Arrange
            var expenseReport = @"
                1721
                979
                366
                299
                675
                1456";

            var expenses = expenseReport
                .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            
            var expenseCalculator = new ExpenseCalculator();
            
            // Act
            var multiply = expenseCalculator.Magic(expenses, matchesToFind);
           
            // Assert
            Assert.That(multiply, Is.EqualTo(expected));
        }
    }
}