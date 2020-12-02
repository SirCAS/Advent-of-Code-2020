using System;
using System.IO;
using System.Linq;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            var splitOptions = StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries;
            
            // Parse input into policy strings and passwords
            var input = File
                .ReadAllText("input.txt")
                .Split(Environment.NewLine, splitOptions)
                .Select(x =>
                {
                    var line = x.Split(':', splitOptions);
                    return new
                    {
                        Policy = line[0],
                        Password = line[1]
                    };
                })
                .ToList();
            
            IPasswordPolicyValidator passwordPolicyValidator = new PasswordPolicyValidator();

            var validCountPolicies = input.Count(x
                => passwordPolicyValidator.CountValidation(x.Policy, x.Password)
            );
            Console.WriteLine(validCountPolicies);
            
            var validPositionPolicies = input.Count(x 
                => passwordPolicyValidator.PositionValidation(x.Policy, x.Password)
            );
            Console.WriteLine(validPositionPolicies);
        }
    }
}