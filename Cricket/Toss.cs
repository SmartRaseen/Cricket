using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cricket
{
    class Toss
    {
        public Toss()
        {
            Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
            Console.WriteLine("Toss For The Match".PadLeft(34));
            Console.WriteLine(AlignmentStructure.tossHeader.PadLeft(34));
            Console.WriteLine();

            bool loopContinue = true;

            while (loopContinue)
            {
                Console.WriteLine("Select Your Choice".PadLeft(21));
                Console.WriteLine(AlignmentStructure.selectchoice.PadLeft(21) + "\n");
                Console.WriteLine(AlignmentStructure.commonSpace + "1. Heads".PadRight(15) + "2. Tails".PadRight(15));
                Console.Write(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Enter Your Choice : ");
                string toss = Console.ReadLine();
                int operationalValue = 0;

                if (int.TryParse(toss,out operationalValue))
                {
                    if (operationalValue == 1)
                    {
                        Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
                        Console.WriteLine(AlignmentStructure.commonSpace + "Result");
                        Console.WriteLine(AlignmentStructure.commonSpace + AlignmentStructure.resultHeader);
                        Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.head);
                        Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.headResult);
                        loopContinue = false;
                    }

                    else if (operationalValue == 2)
                    {
                        Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
                        Console.WriteLine("Result".PadLeft(10));
                        Console.WriteLine(AlignmentStructure.resultHeader.PadLeft(10));
                        Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, AlignmentStructure.tail);
                        Console.WriteLine(AlignmentStructure.newLine + AlignmentStructure.commonSpace + AlignmentStructure.tailResult);
                        loopContinue = false;
                    }

                    else
                        Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Please Give An Valid Data...");

                }

                else
                    Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.commonSpace, "Please Give An Valid Data...");
                

                Console.WriteLine(AlignmentStructure.header3, AlignmentStructure.newLine, AlignmentStructure.line, AlignmentStructure.newLine);
            }
        }
    }
}
