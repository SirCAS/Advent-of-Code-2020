using System;
using System.IO;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            var rules = File.ReadAllLines("input.txt");
            
            var parser = new BagRuleParser();
            var parsedRules = parser.Parse(rules);

            Console.WriteLine(new BagRuleEvaluator(parsedRules).CountBagsWithAtLeastOne("shiny gold"));
            Console.WriteLine(new BagCalculator(parsedRules).CountBags("shiny gold"));
        }
    }
}