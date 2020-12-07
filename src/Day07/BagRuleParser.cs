using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    public class BagRuleParser
    {
        public IDictionary<string, IDictionary<string, int>> Parse(string[] rules)
        {
            // Example "rule light red bags contain 1 bright white bag, 2 muted yellow bags."
            const StringSplitOptions splitOptions = StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries;
            
            return rules.Select(rule =>
            {
                // "rule light red contain 1 bright white, 2 muted yellow"
                var filtered = rule
                    .Replace("bags", string.Empty)
                    .Replace("bag", string.Empty)
                    .Replace(".", string.Empty);

                // "rule light red"
                // "1 bright white, 2 muted yellow"
                var parsed = filtered.Split("contain");

                IDictionary<string, int> allowedColors;
                
                var unparsedAllowedColors = parsed[1].Trim();
                if (!unparsedAllowedColors.Contains("no other"))
                {
                    allowedColors = unparsedAllowedColors
                        .Split(",", splitOptions)
                        .Select(x => x.Split(" ", splitOptions))
                        .ToDictionary(
                            x => string.Join(" ", x.Skip(1)),
                            x => int.Parse(x[0])
                        );
                }
                else
                {
                    allowedColors = new Dictionary<string, int>();
                }

                return new { Color = parsed[0].Trim(), AllowedColors = allowedColors };
                
            }).ToDictionary(
                x => x.Color,
                x => x.AllowedColors
            );
        }
    }
}