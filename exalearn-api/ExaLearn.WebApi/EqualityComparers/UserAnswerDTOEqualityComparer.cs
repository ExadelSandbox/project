using ExaLearn.Bl.DTO;
using System;
using System.Collections.Generic;

namespace ExaLearn.WebApi.EqualityComparers
{
    public class UserAnswerDTOEqualityComparer : IEqualityComparer<UserAnswerDTO>
    {
        public bool Equals(UserAnswerDTO x, UserAnswerDTO y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;

            return x.PassedTestId == y.PassedTestId
                && x.QuestionId == y.QuestionId
                && x.Answer == y.Answer
                && x.FileUrl == y.FileUrl
                && x.Assessment == y.Assessment;
        }

        public int GetHashCode(UserAnswerDTO obj)
        {
            return HashCode.Combine(obj.PassedTestId, obj.QuestionId,
                obj.Answer, obj.FileUrl, obj.Assessment);
        }
    }
}
