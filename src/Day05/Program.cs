using System;
using System.IO;
using System.Linq;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            var seatCalculator = new SeatCalculator();

            var seats = File
                .ReadAllLines("input.txt")
                .Select(boardingPass => seatCalculator.Find(boardingPass).Id)
                .OrderBy(x => x)
                .ToList();
            
            Console.WriteLine(seats.Max());

            for (var i = 0; i < seats.Count - 2; i += 2)
            {
                var hasValidSequence = seats[i] == seats[i + 1] - 1 && seats[i] == seats[i + 2] - 2; 
                if (!hasValidSequence)
                {
                    Console.Write($"{seats[i]}, {seats[i+1]}, {seats[i+2]}");
                    break;
                }
            }
        }
    }
}