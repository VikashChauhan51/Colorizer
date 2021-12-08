using NUnit.Framework;
using Colorizer;
using static Colorizer.Colorizer;
using System;

namespace ColorizerTest
{
    public class Colorizer
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Print_With_Sequential_Parms()
        {
            Write("Hello,first {0} second {1} third {2} forth {3} fifth {4} sixth {5} seventh {6} eighth {7} nineth {8} tenth {9} rest {10} World!", ConsoleColor.Red,
             new Parm { Value = "1", Color = ConsoleColor.Green },
             new Parm { Value = "2", Color = ConsoleColor.Yellow },
             new Parm { Value = "3", Color = ConsoleColor.Blue },
             new Parm { Value = "4", Color = ConsoleColor.Magenta },
             new Parm { Value = "5", Color = ConsoleColor.Cyan },
             new Parm { Value = "6", Color = ConsoleColor.Gray },
             new Parm { Value = "7", Color = ConsoleColor.Green },
             new Parm { Value = "8", Color = ConsoleColor.DarkYellow },
             new Parm { Value = "9", Color = ConsoleColor.White },
             new Parm { Value = "10", Color = ConsoleColor.Cyan },
             new Parm { Value = "11", Color = ConsoleColor.Green });
        }

        [Test]
        public void Print_With_NoN_Sequential_Parms()
        {
            Write("Hello,first {0} second {1} third {3} forth {2} fifth {4} sixth {7} seventh {6} eighth {5} nineth {8} tenth {9} rest {10} World!", ConsoleColor.Red,
             new Parm { Value = "1", Color = ConsoleColor.Green },
             new Parm { Value = "2", Color = ConsoleColor.Yellow },
             new Parm { Value = "3", Color = ConsoleColor.Blue },
             new Parm { Value = "4", Color = ConsoleColor.Magenta },
             new Parm { Value = "5", Color = ConsoleColor.Cyan },
             new Parm { Value = "6", Color = ConsoleColor.Gray },
             new Parm { Value = "7", Color = ConsoleColor.Green },
             new Parm { Value = "8", Color = ConsoleColor.DarkYellow },
             new Parm { Value = "9", Color = ConsoleColor.White },
             new Parm { Value = "10", Color = ConsoleColor.Cyan },
             new Parm { Value = "11", Color = ConsoleColor.Green });
        }
    }
}