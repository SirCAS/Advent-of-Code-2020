using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day04
{
    public class ValidValueValidation : IPassportValidation
    {
        public bool IsValid(IDictionary<string, string> passport)
        {
            //byr (Birth Year) - four digits; at least 1920 and at most 2002.
            if (passport.ContainsKey("byr"))
            {
                var birthYear = int.Parse(passport["byr"]);
                if (birthYear > 2002 || birthYear < 1920)
                    return false;
            }
            
            // iyr (Issue Year) - four digits; at least 2010 and at most 2020.
            if (passport.ContainsKey("iyr"))
            {
                var issueYear = int.Parse(passport["iyr"]);
                if (issueYear > 2020 || issueYear < 2010)
                    return false;
            }

            // eyr (Expiration Year) - four digits; at least 2020 and at most 2030.
            if (passport.ContainsKey("eyr"))
            {
                var issueYear = int.Parse(passport["eyr"]);
                if (issueYear > 2030 || issueYear < 2020)
                    return false;
            }
            
            // hgt (Height) - a number followed by either cm or in:
            //   If cm, the number must be at least 150 and at most 193.
            //   If in, the number must be at least 59 and at most 76.
            if (passport.ContainsKey("hgt"))
            {
                if (passport["hgt"].Contains("cm"))
                {
                    var height = int.Parse(passport["hgt"].Replace("cm", string.Empty));
                    if (height < 150 || height > 193)
                        return false;
                } 
                else if (passport["hgt"].Contains("in"))
                {
                    var height = int.Parse(passport["hgt"].Replace("in", string.Empty));
                    if (height < 59 || height > 76)
                        return false;
                }
                else
                {
                    return false;
                }
            }
            
            // hcl (Hair Color) - a # followed by exactly six characters 0-9 or a-f.
            if (passport.ContainsKey("hcl"))
                if (!Regex.IsMatch(passport["hcl"], "^#([0-9a-fA-F]{6})$"))
                    return false;

            // ecl (Eye Color) - exactly one of: amb blu brn gry grn hzl oth.
            if (passport.ContainsKey("ecl"))
                if (!new[] {"amb", "blu", "brn", "gry", "grn", "hzl", "oth"}.Contains(passport["ecl"]))
                    return false;

            // pid (Passport ID) - a nine-digit number, including leading zeroes.
            if (passport.ContainsKey("pid"))
                if (!Regex.IsMatch(passport["pid"], "^([0-9]{9})$"))
                    return false;

            return true;
        }
    }
}