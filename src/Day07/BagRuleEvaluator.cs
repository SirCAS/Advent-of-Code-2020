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

        public int GetContained()
        {
            return _lookup.Count(rule =>
            {
                return rule.Value.Any(test => GetContained(test.Key));
            });
        }

        private bool GetContained(string targetBag)
        {
            if (targetBag == "shiny gold")
                return true;

            if (!_lookup.ContainsKey(targetBag))
                return false;

            return _lookup[targetBag].Any(x => GetContained(x.Key));
        }
    }
}