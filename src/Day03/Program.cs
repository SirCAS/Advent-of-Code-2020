using System;
using System.IO;
using Day03.Test;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");
            
            var screenBuffer = new ScreenBuffer(input);
            var routePlanner = new RoutePlanner(screenBuffer);
            
            Console.WriteLine(routePlanner.CountTrees(new SlopeModel {Right = 3, Down = 1 }));
        
            var slopes = new[]
            {
                new SlopeModel {Right = 1, Down = 1},
                new SlopeModel {Right = 3, Down = 1},
                new SlopeModel {Right = 5, Down = 1},
                new SlopeModel {Right = 7, Down = 1},
                new SlopeModel {Right = 1, Down = 2},
            };
            
            Console.WriteLine(routePlanner.MultiplyTreeCounts(slopes));

            // 1119827008
            // 9709761600
        }
    }
}