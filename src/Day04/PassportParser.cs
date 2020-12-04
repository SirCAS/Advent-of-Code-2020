using System;
using System.Collections.Generic;
using System.Linq;

namespace Day04
{
    public class PassportParser
    {
        public IList<IDictionary<string, string>> ParsePassports(string data)
        {
            return data
                .Split(Environment.NewLine + Environment.NewLine)
                .Select(ParsePassport)
                .ToList();
        }
        
        public IDictionary<string, string> ParsePassport(string data)
        {
            return data
                .Replace("\n", " ")
                .Split(' ')
                .Select(x => x.Split(':'))
                .ToDictionary(
                    x => x[0],
                    x=> x[1]
                );            
        }
    }
}