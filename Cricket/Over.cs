using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Over
    {
        //public int ball;
        //public int over;
        public Over()
        {
            Ball _ball = new Ball();

            Console.WriteLine("Match Start".PadLeft(27));
            Console.WriteLine(AlignmentStructure.matchStart.PadLeft(27));

            bool isContinue = true;
            while (isContinue)
            {
                Console.Write(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Enter The Overs : ");
                string matchOver = Console.ReadLine();                                                                                                 // Get The Over From The User
                int over = 0;

                if (int.TryParse(matchOver, out over))
                {
                    _ball.Over = over;
                    isContinue = false;
                }
                else
                    Console.WriteLine(AlignmentStructure.header3,AlignmentStructure.newLine,AlignmentStructure.commonSpace,"Please Give An Valid Data");
            }

            bool isloopContinue = true;
            while (isloopContinue)
            {
                Console.Write(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Enter The Balls For Each Over : ");
                string matchBall = Console.ReadLine();                                                                                                 // Get The Balls Per Over
                int ball = 0;

                if (int.TryParse(matchBall, out ball))
                {
                    _ball.BallPerOver = ball;
                    isloopContinue = false;
                }

                else
                    Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Please Give An Valid Data");
            }

            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.newLine, "First Innings".PadLeft(30));
            Console.WriteLine(AlignmentStructure.firstInnings.PadLeft(30));

            User user = new User();
            user.Operation(_ball);
        }
    }
}
