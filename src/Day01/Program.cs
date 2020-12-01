using System;
using System.IO;
using System.Linq;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            var expenses = File.ReadAllLines("input.txt").Select(int.Parse);
            var expenseCalculator = new ExpenseCalculator();
            var match = expenseCalculator.Locate(expenses);
            Console.WriteLine(match.Item1 * match.Item2);
        }
    }
}