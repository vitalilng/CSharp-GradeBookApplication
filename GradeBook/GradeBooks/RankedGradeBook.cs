using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

            if (averageGrade >= Students.Count * 20)
                return 'A';
            else if (averageGrade >= Students.Count * 40 && averageGrade <= Students.Count * 20)
                return 'B';
            else if (averageGrade >= 60 && averageGrade <= Students.Count * 40)
                return 'C';
            else if (averageGrade >= 80 && averageGrade <= Students.Count * 60)
                return 'D';
            else
                return 'F';
        }
    }
}
