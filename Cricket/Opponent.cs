using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Opponent
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
        public int batsmen1Score;
        public int scoredBallCount;
        public double runsRequired;
        public int remainingBall;

        private ScoreDisplayer _scoreDisplayer = new ScoreDisplayer();

        public void Operation(Ball _ball)
        {

            for (int i = 0; i < _ball.Over; i++)
            {
                for (int j = 1; j <= _ball.BallPerOver; j++)
                {
                    int operationValue = 0;
                    Console.Write(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace,"Enter The Score For The Ball (" + i + "." + j + ") : ");
                    string score = Console.ReadLine();

                    int totalBall = _ball.Over * _ball.BallPerOver;

                    ballCount += 1;
                    _ball.Aus_No_Of_BallFaced = ballCount;

                    scoredBallCount += 1;
                    _ball.Aus_No_Of_ScoredBall = scoredBallCount;

                    remainingBall = totalBall - scoredBallCount;
                    _ball.RemainingBall = remainingBall; 

                    if (int.TryParse(score, out operationValue))
                    {
                        if (operationValue == 1)
                        {
                            totalScore += operationValue;
                            runsRequired = _ball.TargetScore - totalScore;
                            _ball.RunsRequired = runsRequired;
                            batsmen1Score += operationValue;
                            _scoreDisplayer.StrikeChange();
                            _scoreDisplayer.Board(totalScore, _ball);                                                       // Get TotalScore
                        }

                        else if (operationValue == 2)
                        {
                            totalScore += operationValue;
                            runsRequired = _ball.TargetScore - totalScore;
                            _ball.RunsRequired = runsRequired;
                            _scoreDisplayer.Board(totalScore, _ball);                                                       // Get TotalScore
                        }

                        else if (operationValue == 3)
                        {
                            totalScore += operationValue;
                            runsRequired = _ball.TargetScore - totalScore;
                            _ball.RunsRequired = runsRequired;
                            _scoreDisplayer.StrikeChange();
                            _scoreDisplayer.Board(totalScore, _ball);                                                       // Get TotalScore
                        }

                        else if (operationValue == 4)
                        {
                            totalScore += operationValue;
                            runsRequired = _ball.TargetScore - totalScore;
                            _ball.RunsRequired = runsRequired;
                            four += 1;
                            _ball.Aus_FourCount = four;                                                                     // Get FourCount                                                        
                            _scoreDisplayer.Board(totalScore, _ball);                                                       // Get TotalScore
                        }

                        else if (operationValue == 5)
                        {
                            totalScore += operationValue;
                            runsRequired = _ball.TargetScore - totalScore;
                            _ball.RunsRequired = runsRequired;
                            _scoreDisplayer.Board(totalScore, _ball);                                                       // Get TotalScore
                        }

                        else if (operationValue == 6)
                        {
                            totalScore += operationValue;
                            runsRequired = _ball.TargetScore - totalScore;
                            _ball.RunsRequired = runsRequired;
                            six += 1;
                            _ball.Aus_SixCount = six;                                                                       // Get SixCount        
                            _scoreDisplayer.Board(totalScore, _ball);                                                       // Get TotalScore
                        }

                        else
                        {
                            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace,AlignmentStructure.giveValidData);
                            ballCount -= 1;
                            scoredBallCount -= 1;                         // If its not a Scored Ball, Don't take that count
                            --j;
                            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
                        }
                    }

                    else if (score == string.Empty)
                    {
                        Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace,AlignmentStructure.giveValidData);
                        ballCount -= 1;
                        scoredBallCount -= 1;                             // If its not a Scored Ball, Don't take that count
                        --j;
                        Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
                    }

                    else
                    {
                        switch (score)
                        {
                            case "d":
                            case "D":
                                dotBall += 1;
                                _ball.Aus_No_Of_DotBall = dotBall;                                                          // Get DotBallCount
                                totalScore = totalScore + 0;
                                runsRequired = _ball.TargetScore - totalScore;
                                _ball.RunsRequired = runsRequired;
                                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.dotBallNoRuns);
                                _scoreDisplayer.Board(totalScore, _ball);                                                   // Get TotalScore
                                break;

                            case "w":
                            case "W":
                                wideBall += 1;
                                _ball.Aus_No_Of_WideBall = wideBall;
                                totalScore += 1;
                                runsRequired = _ball.TargetScore - totalScore;
                                _ball.RunsRequired = runsRequired;
                                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.wideBall);             // Get WideBall Count
                                _scoreDisplayer.Board(totalScore, _ball);                                                   // Get TotalScore
                                scoredBallCount -= 1;                                                                       // If its not a Scored Ball, Don't take the count
                                --j;
                                break;

                            case "n":
                            case "N":
                                noBall += 1;
                                _ball.Aus_No_Of_NoBall = noBall;
                                totalScore += 1;                                                                            // Get NoBall Count
                                runsRequired = _ball.TargetScore - totalScore;
                                _ball.RunsRequired = runsRequired;
                                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.noBall);              // If its not a Scored Ball, Don't take the count
                                _scoreDisplayer.Board(totalScore, _ball);                                                   // Get TotalScore
                                scoredBallCount -= 1;
                                --j;
                                break;

                            case "wk":
                            case "Wk":
                                changeBatsmen += 1;
                                _scoreDisplayer.onStrikeBatsmen = Team.AustralianBatsmen[1 + changeBatsmen];                    // Change Batsmen
                                runsRequired = _ball.TargetScore - totalScore;
                                _ball.RunsRequired = runsRequired;
                                wicket += 1;
                                _ball.Aus_No_Of_Wicket = wicket;                                                            // Get Wicket Count
                                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.wicket);
                                _scoreDisplayer.Board(totalScore, _ball);
                                break;

                            default:
                                Console.WriteLine(AlignmentStructure.header3 ,AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.giveValidData);
                                ballCount -= 1;
                                scoredBallCount -= 1;                  // If its not a Scored Ball, Don't take the count
                                --j;
                                Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
                                break;
                        }
                    }
                }
                Console.WriteLine(AlignmentStructure.header_5, AlignmentStructure.newLine, AlignmentStructure.commonSpace,"Over : ", i + 1, " Completed, Strike Changed...");
                _scoreDisplayer.StrikeChange();
                _scoreDisplayer.BowlerChange();
                Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
            }
            Result result = new Result();
            result.SecondInnings(_ball);
            result.ResultAnnouncer(totalScore,_ball);
        }
    }
}
