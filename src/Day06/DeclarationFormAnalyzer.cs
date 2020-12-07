using System;
using System.Linq;

namespace Day06.Test
{
    public class DeclarationFormAnalyzer
    {
        public int CountSumWithOneYes(string input)
        {
            return input
                .Split(Environment.NewLine + Environment.NewLine)
                .Sum(group => group
                    .Replace(Environment.NewLine, String.Empty)
                    .Distinct()
                    .Count()
                );
        }
        
        public int CountSumWithAllYes(string input)
        {
            return input
                .Split(Environment.NewLine + Environment.NewLine)
                .Sum(group =>
                {
                    var persons = group.Split(Environment.NewLine).Length;
                    var sum = group//.Replace(Environment.NewLine, string.Empty)
                        .GroupBy(x => x)
                        .Count(x => x.Count() == persons);

                    return sum;
                });
        }

    }
}