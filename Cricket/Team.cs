using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Team
    {
        public static void Match()
        {
            Console.WriteLine(AlignmentStructure.header2,AlignmentStructure.newLine2,AlignmentStructure.playing11Squad.PadLeft(30));        // Pick Playing 11 Squad For Both Team
            Console.WriteLine(AlignmentStructure.matchHeader.PadLeft(30));
            GetIndianPlayer();
            GetAusPlayer();
        }

        private static void GetIndianPlayer()
        {
            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.newLine2, "Team India".PadLeft(26));                           // Team India
            Console.WriteLine(AlignmentStructure.teamHeader.PadLeft(26));

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"1 : Rohit Sharma","2 : Shikhar Dhawan"},
                {"3 : Virat Kholi","4 : MS Dhoni"},
                {"5 : Suresh Raina","6 : Yuvraj Singh"},
                {"7 : Hardik Pandya","8 : Jadeja"},
                {"9 : Bumrah","10 : Harbhajan Singh"},
                {"11 : Ashwin",""},
            };

            DisplayPlayer(dict);                                                                                                            // Display Squad Players
        }

        private static void DisplayPlayer(Dictionary<string, string> dict)
        {
            foreach (KeyValuePair<string, string> item in dict)
            {
                Console.WriteLine("\n {0} | {1}", item.Key.PadRight(23), item.Value);
            }
        }

        private static void GetAusPlayer()
        {
            Console.WriteLine(AlignmentStructure.header2,AlignmentStructure.newLine2,"Team Australia".PadLeft(30));                         // Team Australia
            Console.WriteLine(AlignmentStructure.teamHeader2.PadLeft(30));

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"1 : Aaron Finch","2 : David Warner"},
                {"3 : Steven Smith","4 : Glenn Maxwell"},
                {"5 : Jason Behrendorff","6 : Marcus Stoinis"},
                {"7 : Alex Carey","8 : Nathan Coulter-Nile"},
                {"9 : Mitchell Starc","10 : Pat Cummins"},
                {"11 : Peter Handscomb",""},
            };

            DisplayPlayer(dict);
        }

        public static List<string> IndianBatsmen = new List<string>()                                                                       // Indian Batsmen
        {
            "Rohit Sharma",
            "Shikhar Dhawan",
            "Virat Kholi",     
            "MS Dhoni",
            "Suresh Raina",
            "Yuvraj Singh",  
            "Hardik Pandya",
            "Jadeja",
            "Bumrah",
            "Harbhajan Singh",
            "Ashwin"
        };

        public static List<string> IndianBowler = new List<string>()                                                                        // Indian Bowler
        {
            "Bumrah",
            "Ashwin",
            "Harbhajan Singh",
            "Jadeja",
            "Hardik Pandya",
            "Yuvraj Singh"
        };


        public static List<string> AustralianBatsmen = new List<string>()                                                                   // Australian Batsmen
        {
            "Aaron Finch",
            "David Warner",
            "Smith",
            "Glenn Maxwell",
            "Jason Behrendorff",
            "Marcus Stoinis",
            "Alex Carey",
            "Nathan Coulter-Nile",
            "Mitchell Starc",
            "Pat Cummins",
            "Peter Handscomb"
        };

        public static List<string> AustraliaBowler = new List<string>()                                                                     // Australian Bowler
        {
            "Mitchell Starc",
            "Marcus Stoinis",
            "Pat Cummins",
            "Peter Handscomb",
            "Alex Carey",
            "Nathan Coulter-Nile"
        };
    }
}
