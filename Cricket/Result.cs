using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Result
    {
        private double run;

        public void SecondInnings(Ball _ball)
        {
            // Second Innings Result
            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.newLine, AlignmentStructure.secondInningsResult.PadLeft(30));
            Console.WriteLine(AlignmentStructure.secondInningsResultLine.PadLeft(30));
            Console.WriteLine(AlignmentStructure.header4, AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.indiaScored, _ball.TotalScore);            // India Total Score                                        // India Total Score
            Console.WriteLine(AlignmentStructure.header4, AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.ausScored, _ball.Aus_TotalScore);          // Australia Total Score                                  // Australia Total Score
            Console.WriteLine(AlignmentStructure.header3,AlignmentStructure.newLine,AlignmentStructure.line,AlignmentStructure.newLine);
        }

        public void ResultAnnouncer(double totalScoreAus, Ball _ball)
        {
            Console.WriteLine(AlignmentStructure.header2,AlignmentStructure.newLine,"Match Result".PadLeft(30));
            Console.WriteLine(AlignmentStructure.matchResult.PadLeft(30));

            if (_ball.TotalScore > totalScoreAus)
            {
                run = _ball.TotalScore - totalScoreAus;
                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.indiaWon);                        // India Won The Match
                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.indiaBeat,run);                   // India Won By Number Of Runs
            }

            else if (_ball.TotalScore < totalScoreAus)
            {
                run = totalScoreAus - _ball.TotalScore;
                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.ausWon);                          // Australia Won The Match
                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.ausBeat,run);                     // Australia Won By Number Of Runs
            }

            else if (_ball.TotalScore == totalScoreAus)
            {
                run = _ball.TotalScore;
                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.sameScore,run);                   // Match Tied
                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.matchTied);                       // Both Teams Scored Same Runs
            }

            Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.line);
        }
    }
}
