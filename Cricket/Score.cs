using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{                                                               
    class Score
    {

        public static List<Player> indianPlayer = new List<Player>()
        {
            new Player() { name = "Rohit Sharma", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Shikhar Dhawan", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Virat Kholi", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "MS Dhoni", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Suresh Raina", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Yuvraj Singh", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Hardik Pandya", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Jadeja", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Bumrah", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Harbhajan Singh", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Ashwin", score = 0, six = 0, four = 0, strikeRate = 0 },
        };

        public static void DisplayScoreCard()
        {
            var display = indianPlayer.GroupBy(s => s.name);

            foreach(var group in display)
            {
                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + "PlayerName : {0}", group.Key);
                Console.WriteLine(AlignmentStructure.commonSpace + AlignmentStructure.playerheader);

                foreach (var result in group)
                {
                    Console.WriteLine(AlignmentStructure.header_6, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Score".PadRight(20), "Six".PadRight(20), "Four".PadRight(20), "StrikeRate".PadRight(20));
                    Console.WriteLine(AlignmentStructure.header_7, AlignmentStructure.newLine, AlignmentStructure.commonSpace, result.score, result.six, result.four, result.strikeRate);
                }

                Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.line);
            }
        }

        public static List<Player> australianPlayer = new List<Player>()
        {
            new Player() { name = "Aaron Finch", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "David Warner", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Smith", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Glenn Maxwell", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Jason Behrendorff", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Marcus Stoinis", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Alex Carey", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Nathan Coulter-Nile", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Mitchell Starc", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Pat Cummins", score = 0, six = 0, four = 0, strikeRate = 0 },
            new Player() { name = "Peter Handscomb", score = 0, six = 0, four = 0, strikeRate = 0 },
        };

    }
}
