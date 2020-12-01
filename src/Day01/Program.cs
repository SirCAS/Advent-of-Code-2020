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
            
            // Part 1
            Console.WriteLine(expenseCalculator.Magic(expenses, 2));
            
            // Part 2
            Console.WriteLine(expenseCalculator.Magic(expenses, 3));
        }
    }
}