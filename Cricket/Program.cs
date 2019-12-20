using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AlignmentStructure.header2, AlignmentStructure.newLine2,"Cricket Score Maintenance".PadLeft(35));
            Console.WriteLine(AlignmentStructure.programHeader.PadLeft(35));
            Team.Match();
            Toss _toss = new Toss();
            Over _over = new Over();
            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Press any key to exit (Thank You..)");
            Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.line1);
            Console.ReadLine();
        }
    }
}
