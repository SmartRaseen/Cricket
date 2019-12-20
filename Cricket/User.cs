using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class User
    {
        public int six;
        public int four;
        public int wicket;
        public int dotBall;
        public int wideBall;
        public int noBall;
        public int ballCount;
        public int totalScore;
        public int changeBatsmen;
        public int scoredBallCount;

        private ScoreBoard _scoreBoard = new ScoreBoard();

        public void Operation(Ball _ball)
        {

            for (int i = 0; i < _ball.Over; i++)
            {
                for (int j = 1; j <= _ball.BallPerOver; j++)
                {
                    int operationValue = 0;
                    Console.Write(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Enter The Score For The Ball (" + i + "." + j + ") : ");
                    string score = Console.ReadLine();

                    ballCount = ballCount + 1;
                    _ball.No_Of_BallFaced = ballCount;

                    scoredBallCount = scoredBallCount + 1;
                    _ball.No_Of_ScoredBall = scoredBallCount;


                    if (int.TryParse(score, out operationValue))
                    {
                        if (operationValue == 1)
                        {
                            totalScore += operationValue;
                            _scoreBoard.onStrikeBatsmen += operationValue;
                            //_scoreBoard.ScoreCalculator();
                            _scoreBoard.StrikeChange();
                            _scoreBoard.Board(totalScore, _ball);                                                                       // Get TotalScore
                        }

                        else if (operationValue == 2)
                        {
                            totalScore += operationValue;
                            _scoreBoard.onStrikeBatsmen += operationValue;
                            _scoreBoard.Board(totalScore, _ball);                                                                       // Get TotalScore
                        }

                        else if (operationValue == 3)
                        {
                            totalScore += operationValue;
                            _scoreBoard.onStrikeBatsmen += operationValue;
                            _scoreBoard.ScoreCalculator();
                            _scoreBoard.StrikeChange();
                            _scoreBoard.Board(totalScore, _ball);                                                                       // Get TotalScore
                        }

                        else if (operationValue == 4)
                        {
                            totalScore += operationValue;
                            _scoreBoard.onStrikeBatsmen += operationValue;
                            four += 1;
                            _ball.FourCount = four;                                                                                     // Get FourCount                                                        
                            _scoreBoard.Board(totalScore, _ball);                                                                       // Get TotalScore
                        }

                        else if (operationValue == 5)
                        {
                            totalScore += operationValue;
                            _scoreBoard.ScoreCalculator();
                            _scoreBoard.StrikeChange();
                            _scoreBoard.onStrikeBatsmen += operationValue;
                            _scoreBoard.Board(totalScore, _ball);                                                                       // Get TotalScore
                        }

                        else if (operationValue == 6)
                        {
                            totalScore += operationValue;
                            _scoreBoard.onStrikeBatsmen += operationValue;
                            six += 1;
                            _ball.SixCount = six;                                                                                       // Get SixCount        
                            _scoreBoard.Board(totalScore, _ball);                                                                       // Get TotalScore
                        }

                        else
                        {
                            Console.WriteLine(AlignmentStructure.header3,AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.giveValidData);
                            ballCount -= 1;
                            scoredBallCount -= 1;                                                                                       // If its not a Scored Ball, Don't take that count
                            --j;
                            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
                        }
                    }

                    else if (score == string.Empty)
                    {
                        Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.giveValidData);    // If its empty, Response like Please give valid data
                        ballCount -= 1;
                        scoredBallCount -= 1;                                                                                           // If its not a Scored Ball, Don't take that count
                        --j;
                        Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
                    }

                    else
                    {
                        switch (score)
                        {
                            case "d":
                            case "D":
                                dotBall = dotBall + 1;                                                                                      // Get DotBallCount
                                _ball.No_Of_DotBall = dotBall;                                                                          
                                totalScore = totalScore + 0;                                                                                // Get TotalScore
                                Console.WriteLine(AlignmentStructure.header2,AlignmentStructure.newLine, AlignmentStructure.dotBallNoRuns); // Dot Ball! No Runs... 
                                _scoreBoard.Board(totalScore, _ball);                                                                   
                                break;

                            case "w":
                            case "W": 
                                wideBall = wideBall + 1;                                                                                // Get WideBall Count
                                _ball.No_Of_WideBall = wideBall;                                                                        
                                totalScore = totalScore + 1;                                                                            // Get TotalScore
                                Console.WriteLine(AlignmentStructure.header2,AlignmentStructure.newLine, AlignmentStructure.wideBall);  //Wide Ball! Run and Rebowl...
                                _scoreBoard.Board(totalScore, _ball);                                                                   
                                scoredBallCount -= 1;                                                                                   // If its not a Scored Ball, Don't take the count
                                --j;
                                break;

                            case "n":
                            case "N":
                                noBall = noBall + 1;
                                _ball.No_Of_NoBall = noBall;
                                totalScore = totalScore + 1;                                                                            // Get NoBall Count
                                Console.WriteLine(AlignmentStructure.header2,AlignmentStructure.newLine, AlignmentStructure.noBall); ;  
                                _scoreBoard.Board(totalScore, _ball);                                                                   // Get TotalScore
                                scoredBallCount -= 1;
                                --j;                                                                                                    // If its not a Scored Ball, Don't take the count
                                break;

                            case "wk":
                            case "Wk":
                                changeBatsmen = changeBatsmen + 1;
                                //_scoreBoard.onStrikeBatsmen = Score.indianPlayer[1 + changeBatsmen].score;
                                _scoreBoard.onstrikeBatsmen = Team.IndianBatsmen[1 + changeBatsmen];                                    // Change Batsmen
                                wicket = wicket + 1;
                                _ball.No_Of_Wicket = wicket;                                                                            // Get Wicket Count
                                Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.newLine, AlignmentStructure.wicket);
                                _scoreBoard.Board(totalScore, _ball);
                                break;

                            default:
                                Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.giveValidData);
                                ballCount -= 1;
                                scoredBallCount -= 1;                                                                                   // If its not a Scored Ball, Don't take the count
                                --j;
                                Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
                                break;
                        }

                    }
                }
                Console.WriteLine(AlignmentStructure.header_5, AlignmentStructure.newLine, AlignmentStructure.commonSpace,"Over : ", i+1 ," Completed, Strike Changed...");
                _scoreBoard.StrikeChange();
                _scoreBoard.BowlerChange();
                Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
            }
            RunChase runChase = new RunChase();
            runChase.Chase(_ball);
        }

    }
}
