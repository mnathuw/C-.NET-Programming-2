using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class GradeItem
    {
        private decimal score;
        private decimal maxScore;
        public GradeItem (decimal score, decimal maxScore)
        {
            this.score = score;
            this.maxScore = maxScore;
        }
        public LetterGrade GetLetterGrade()
        {
            switch (score / maxScore)
            {
                case 0.9M:
                    return LetterGrade.APlus;
                case 0.8M:
                    return LetterGrade.A;
                case 0.75M:
                    return LetterGrade.BPlus;
                case 0.7M:
                    return LetterGrade.B;
                case 0.65M:
                    return LetterGrade.CPlus;
                case 0.6M:
                    return LetterGrade.C;
                case 0.5M:
                    return LetterGrade.D;
                default:
                    return 0M;
            }
        }
    }
}
