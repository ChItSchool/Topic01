using System;

namespace ConsoleProgressBar
{
    class Program
    {
        static void Main(string[] args)
        {
            RebuildConsole(0);

            for (int i = 0; i < 100000; i++)
            {
                RebuildConsole(i);
                Console.WriteLine("  //");
                for (int ii = 0; ii <20000000; ii++)
                {
                    i++;
                    i--;
                }

                RebuildConsole(i);
                Console.WriteLine("  ||");
                for (int ii = 0; ii <20000000; ii++)
                {
                    i++;
                    i--;
                }

                RebuildConsole(i);
                Console.WriteLine(@"  \\");
                for (int ii = 0; ii < 20000000; ii++)
                {
                    i++;
                    i--;
                }

                RebuildConsole(i);
                Console.WriteLine("  ||");
                for (int ii = 0; ii < 20000000; ii++)
                {
                    i++;
                    i--;
                }
            }
            var s = Console.ReadLine();
        }

        static void RebuildConsole(int i)
        {
            Console.Clear();
            Console.WriteLine( "   | ");
            Console.WriteLine( "   | ");
            Console.WriteLine( "  0| ");

            if (i % 2 == 1 )
                Console.WriteLine(@" |()|");
            else
                Console.WriteLine(@" /()\");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
             Console.BackgroundColor = ConsoleColor.DarkGreen;
             Console.Title = "Progres Bar";

        }


    }
}
