using System.Collections.Generic;

namespace Day04
{
    public interface IPassportValidation
    {
        bool IsValid(IDictionary<string, string> passport);
    }
}