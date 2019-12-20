using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class ScoreDisplayer
    {
        public string onStrikeBatsmen = Team.AustralianBatsmen[0];
        public string offStrikeBatsmen = Team.AustralianBatsmen[1];
        public string strikeBowler = Team.IndianBowler[0];
        public int changeBowler;

        public void StrikeChange()
        {
            string temp = onStrikeBatsmen;
            onStrikeBatsmen = offStrikeBatsmen;
            offStrikeBatsmen = temp;
        }

        public void ChangeBowler()
        {
            changeBowler = changeBowler + 1;
            strikeBowler = Team.IndianBowler[changeBowler];
        }

        public void Board(double totalScore, Ball _ball)
        {
            _ball.Aus_Extras = _ball.Aus_No_Of_WideBall + _ball.Aus_No_Of_NoBall;
            _ball.Aus_TotalScore = totalScore;

            double currentRunRate = totalScore / _ball.Aus_No_Of_ScoredBall;
            double requiredRunRate = _ball.RunsRequired / _ball.RemainingBall;
            
            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Score Board");
            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.commonSpace, AlignmentStructure.scoreBoard);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.header6, AlignmentStructure.commonSpace, "Batsmen*".PadRight(23), "Batsmen".PadRight(23), "Bowler".PadRight(23), "FallOfWickets".PadRight(23), "TotalScore" + AlignmentStructure.newLine);
            Console.WriteLine(AlignmentStructure.header9, AlignmentStructure.commonSpace, onStrikeBatsmen.PadRight(23), offStrikeBatsmen.PadRight(23), strikeBowler.PadRight(23), _ball.Aus_No_Of_Wicket, totalScore);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.commonSpace, "Statistics");
            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.commonSpace, AlignmentStructure.statistic);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.header7, AlignmentStructure.commonSpace, "BallsFaced".PadRight(20), "DotBalls".PadRight(16), "WideBalls".PadRight(18), "NoBalls".PadRight(15), "Fours".PadRight(17), "Sixes".PadRight(15) + AlignmentStructure.newLine);
            Console.WriteLine(AlignmentStructure.header8, AlignmentStructure.commonSpace, _ball.Aus_No_Of_BallFaced, _ball.Aus_No_Of_DotBall, _ball.Aus_No_Of_WideBall, _ball.Aus_No_Of_NoBall, _ball.Aus_FourCount, _ball.Aus_SixCount);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.commonSpace + "Extras : " + _ball.Aus_Extras);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.commonSpace + "Run Rate");
            Console.WriteLine(AlignmentStructure.commonSpace + AlignmentStructure.runRate + AlignmentStructure.newLine);
            Console.WriteLine(AlignmentStructure.commonSpace + "Current RunRate : " + currentRunRate);
            Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + "Required RunRate : {0}", requiredRunRate);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

        }

        public void BowlerChange()
        {
            bool loopContinue = true;
            while (loopContinue)
            {
                Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Do you want to change bowler? Y or N");
                Console.Write(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Select your choice : ");
                string userWish = Console.ReadLine();

                if (userWish == "Y" || userWish == "y")
                {
                    ChangeBowler();
                    loopContinue = false;
                }

                else if (userWish == "N" || userWish == "n")
                    loopContinue = false;

                else
                {
                    Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine2, AlignmentStructure.commonSpace, " Please Select Valid Data");
                    Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);
                }
            }
        }
    }
}
