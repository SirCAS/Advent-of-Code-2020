using System.Collections.Generic;
using System.Linq;

namespace Day04
{
    public class RequriedFieldsValidation : IPassportValidation
    {
        private readonly string[] _neededEntries = {
            "byr",
            "iyr",
            "eyr",
            "hgt",
            "hcl",
            "ecl",
            "pid",
            "cid"
        };

        public bool IsValid(IDictionary<string, string> passport)
        {
            var validEntries = _neededEntries.Count(passport.ContainsKey);
            if (validEntries == _neededEntries.Length)
                return true;

            if (validEntries == _neededEntries.Length - 1 && !passport.ContainsKey("cid"))
                return true;
            
            return false;
        }
    }
}