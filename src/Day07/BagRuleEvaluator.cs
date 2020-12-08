using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    public class BagRuleEvaluator
    {
        private readonly IDictionary<string, IDictionary<string, int>> _lookup;

        public BagRuleEvaluator(IDictionary<string, IDictionary<string, int>> lookup)
        {
            _lookup = lookup;
        }

        public int CountBagsWithAtLeastOne(string desiredColor)
        {
            return _lookup.Count(rule =>
            {
                return rule.Value.Any(test => GetContained(desiredColor, test.Key));
            });
        }

        private bool GetContained(string desiredColor, string targetBag)
        {
            if (targetBag == desiredColor)
                return true;

            if (!_lookup.ContainsKey(targetBag))
                return false;

            return _lookup[targetBag].Any(x => GetContained(desiredColor,x.Key));
        }
    }
}