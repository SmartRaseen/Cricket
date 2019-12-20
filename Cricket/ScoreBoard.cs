using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    public class ScoreBoard 
    {
        public string onstrikeBatsmen = Team.IndianBatsmen[0];
        public string offstrikeBatsmen = Team.IndianBatsmen[1];
        public string bowler = Team.AustraliaBowler[0];
        public int changeBowler;

        public int onStrikeBatsmen;
        public int offStrikeBatsmen;

        public int batsmenStrike;
        public int batsmenOffStrike;

        public void ScoreCalculator()
        {
            int temp = Score.indianPlayer[0].score;
            Score.indianPlayer[0].score = Score.indianPlayer[1].score;
            Score.indianPlayer[1].score = temp;
        }

        public void StrikeChange()
        {
            string temp = onstrikeBatsmen;
            onstrikeBatsmen = offstrikeBatsmen;
            offstrikeBatsmen = temp;
        }

        public void ChangeBowler()
        {
            changeBowler = changeBowler + 1;
            bowler = Team.AustraliaBowler[changeBowler];
        }

        public void Board(double totalScore, Ball _ball)
        {
            _ball.Extras = _ball.No_Of_WideBall + _ball.No_Of_NoBall;
            _ball.TotalScore = totalScore;
            double currentRunRate = totalScore / _ball.No_Of_ScoredBall;

            Score.indianPlayer[0].score = onStrikeBatsmen;
            Score.indianPlayer[1].score = offStrikeBatsmen;

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Score Board");
            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.commonSpace, AlignmentStructure.scoreBoard);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.header6, AlignmentStructure.commonSpace,"Batsmen*".PadRight(23), "Batsmen".PadRight(23), "Bowler".PadRight(23), "FallOfWickets".PadRight(23), "TotalScore"+ AlignmentStructure.newLine);
            Console.WriteLine(AlignmentStructure.header9, AlignmentStructure.commonSpace, onstrikeBatsmen.PadRight(23), offstrikeBatsmen.PadRight(23), bowler.PadRight(23), _ball.No_Of_Wicket, totalScore);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.commonSpace, "Statistics");
            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.commonSpace, AlignmentStructure.statistic);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.header7, AlignmentStructure.commonSpace, "BallsFaced".PadRight(20), "DotBalls".PadRight(16), "WideBalls".PadRight(18), "NoBalls".PadRight(15), "Fours".PadRight(17), "Sixes".PadRight(15) + AlignmentStructure.newLine);
            Console.WriteLine(AlignmentStructure.header8, AlignmentStructure.commonSpace, _ball.No_Of_BallFaced, _ball.No_Of_DotBall, _ball.No_Of_WideBall, _ball.No_Of_NoBall, _ball.FourCount, _ball.SixCount);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.commonSpace + " Extras : " + _ball.Extras);

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);

            Console.WriteLine(AlignmentStructure.commonSpace + "Run Rate");
            Console.WriteLine(AlignmentStructure.commonSpace + AlignmentStructure.runRate + AlignmentStructure.newLine);
            Console.WriteLine(AlignmentStructure.commonSpace + "Current RunRate : " + currentRunRate);

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
                    Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine2, AlignmentStructure.commonSpace, "Please Select Valid Data");
                    Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line1, AlignmentStructure.newLine);
                }
            }
        }
    }
}
