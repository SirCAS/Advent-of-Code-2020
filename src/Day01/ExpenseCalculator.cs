using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

namespace Day01
{
    public class ExpenseCalculator
    {
        public int Magic(IEnumerable<int> expenses, int matchesToFind)
        {
            var mutations = expenses.GetPermutations(matchesToFind);
            foreach (var mutation in mutations)
            {
                if(mutation.Sum() == 2020)
                    return mutation.Aggregate(1, (a, b) => a * b);
            }
            
            throw new ArgumentException("Couldn't find any expenses which matches criteria");
        }
    }
}