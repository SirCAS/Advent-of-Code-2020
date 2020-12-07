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
            
            var evaluator = new BagRuleEvaluator(parsedRules);

            Console.WriteLine(evaluator.GetContained());
        }
    }
}