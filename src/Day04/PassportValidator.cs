using System.Collections.Generic;
using System.Linq;

namespace Day04
{
    public class PassportValidator
    {
        private readonly IList<IPassportValidation> _validations;

        public PassportValidator(IList<IPassportValidation> validations)
        {
            _validations = validations;
        }

        public int CountValid(IList<IDictionary<string, string>> passports)
        {
            return passports.Count(passport =>
            {
                return _validations.All(strategy => strategy.IsValid(passport));
            });
        }
    }
}