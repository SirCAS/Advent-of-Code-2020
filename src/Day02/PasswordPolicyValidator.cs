using System.Linq;

namespace Day02
{
    public interface IPasswordPolicyValidator
    {
        bool CountValidation(string unparsedPolicy, string password);
        bool PositionValidation(string unparsedPolicy, string password);
    }

    public class PasswordPolicyValidator : IPasswordPolicyValidator
    {
        public bool CountValidation(string unparsedPolicy, string password)
        {
            var policy = ExtractPolicy(unparsedPolicy);

            var countOfLetter = password.Count(x => x == policy.Letter);

            return countOfLetter >= policy.FirstPosition && countOfLetter <= policy.LastPosition;
        }

        public bool PositionValidation(string unparsedPolicy, string password)
        {
            var policy = ExtractPolicy(unparsedPolicy);

            var rangesIsWithinIndexesOfPassword = password.Length >= policy.FirstPosition && password.Length >= policy.LastPosition;
            if (!rangesIsWithinIndexesOfPassword)
            {
                return false;
            }

            var match1 = password[policy.FirstPosition - 1] == policy.Letter;
            var match2 = password[policy.LastPosition - 1] == policy.Letter;
            
            // Only one positive match is allowed
            return (match1 || match2) && (match1 != match2);
        }

        private PolicyModel ExtractPolicy(string policy)
        {
            // Example input "5-6 s: gsfsss"
            var rangeSplits = policy.Split('-');
            var letterSplit = rangeSplits[1].Split(' ');

            return new PolicyModel
            {
                Letter = letterSplit[1][0],
                FirstPosition = int.Parse(rangeSplits[0]),
                LastPosition = int.Parse(letterSplit[0])
            };
        }
        
        private class PolicyModel
        {
            public char Letter { get; set; }
            public int FirstPosition { get; set; }
            public int LastPosition { get; set; }
        }
    }
}