﻿using System;
using System.IO;
using Day06.Test;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("input.txt");
            
            var analyzer = new DeclarationFormAnalyzer();

            Console.WriteLine(analyzer.CountSumWithOneYes(input));
            Console.WriteLine(analyzer.CountSumWithAllYes(input));
        }
    }
}