using System;
using System.IO;
using Day04.Validation;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("input.txt");
            
            var passports = new PassportParser().ParsePassports(input);
            
            var passportValidatorPart1 = new PassportValidator(new []
            {
                new RequriedFieldsValidation()
            });

            Console.WriteLine(passportValidatorPart1.CountValid(passports));

            var passportValidatorPart2 = new PassportValidator(new IPassportValidation[]
            {
                new RequriedFieldsValidation(),
                new ValidValueValidation()
            });
            
            Console.WriteLine(passportValidatorPart2.CountValid(passports));


        }
    }
}