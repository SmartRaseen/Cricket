using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class RunChase
    {
        public void Chase(Ball _ball)
        {
            // ScoreCard
            //Console.WriteLine(AlignmentStructure.header2,AlignmentStructure.newLine,"Match Score Card".PadLeft(20));
            //Console.WriteLine(AlignmentStructure.header,AlignmentStructure.matchCard.PadLeft(20));
            //Score.DisplayScoreCard();                                                                                                                                                 // Player Score Card
            // First Innings Result
            Console.WriteLine(AlignmentStructure.header2,AlignmentStructure.newLine,AlignmentStructure.firstInningsResult.PadLeft(30));
            Console.WriteLine(AlignmentStructure.firstInningsResultLine.PadLeft(30));
            Console.WriteLine(AlignmentStructure.header4, AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.indiaScore, _ball.TotalScore);                 // India Total Score Using Class Ball (Property)
            _ball.TargetScore = _ball.TotalScore + 1;                                                                                                                                   // Get TargetScore Using (TotalScore + 1)
            Console.WriteLine(AlignmentStructure.header4, AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.ausChaseTarget, _ball.TargetScore);            // Australia Ready To Face The Target
            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
            
            // Second Innings Start
            Console.WriteLine(AlignmentStructure.secondInningsStart.PadLeft(31));
            Console.WriteLine(AlignmentStructure.secondInningsLine.PadLeft(31));
            var user = new Opponent();
            user.Operation(_ball);
        }
    }
}
