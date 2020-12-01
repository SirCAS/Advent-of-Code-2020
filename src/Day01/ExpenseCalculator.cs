using System;
using System.Collections.Generic;

namespace Day01
{
    public class ExpenseCalculator
    {
        public (int, int) Locate(IEnumerable<int> expenses)
        {
            foreach (var expense1 in expenses)
            {
                foreach (var expense2 in expenses)
                {
                    if (expense1 + expense2 == 2020)
                        return (expense1, expense2);
                }
            }
            
            throw new ArgumentException("No valid expenses to locate");
        }
    }
}