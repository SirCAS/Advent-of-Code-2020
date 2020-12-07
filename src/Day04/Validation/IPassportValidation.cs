using System.Collections.Generic;

namespace Day04.Validation
{
    public interface IPassportValidation
    {
        bool IsValid(IDictionary<string, string> passport);
    }
}