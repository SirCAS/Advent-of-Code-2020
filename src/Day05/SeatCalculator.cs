using System;
using System.Linq;

namespace Day05
{
    public class SeatCalculator
    {
        public Seat Find(string boardingPass)
        {
            var rowInput = boardingPass.Substring(0, 7);
            var columnInput = boardingPass.Substring(7);
            
            return new Seat
            {
                Row = Find(rowInput, 'F', 0, 'B', 127),
                Column = Find(columnInput, 'L', 0, 'R', 7)
                
            };
        }
        
        private int Find(string input, char downLetter, int start, char upLetter, int end)
        {
            foreach (var character in input.Substring(0, input.Length - 1))
            {
                var diff = Math.Round((double) (end - start) / 2);
                
                if (character == downLetter)
                {
                    end -= Convert.ToInt32(diff);
                }

                if (character == upLetter)
                {
                    start += Convert.ToInt32(diff);
                }
            }

            if (input.Last() == downLetter)
            {
                return start;
            }

            return end;
        }
    }
}