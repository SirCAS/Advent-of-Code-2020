using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    public class BagCalculator
    {
        private readonly IDictionary<string, IDictionary<string, int>> _lookup;

        public BagCalculator(IDictionary<string, IDictionary<string, int>> lookup)
        {
            _lookup = lookup;
        }

        public int CountBags(string outerBag)
        {
            return CountBagsWithin(outerBag) - 1;
        }
        
        private int CountBagsWithin(string bagColor)
        {
            var start = _lookup[bagColor];
            if (start.Count == 0)
                return 1;
            
            return  1 + start.Sum(x => x.Value * CountBagsWithin(x.Key));
        }

    }
}