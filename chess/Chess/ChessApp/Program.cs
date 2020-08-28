using System;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("▓░▓░▓░▓░");

            Console.WriteLine("░▓░▓░▓░▓");

            Console.WriteLine("▓░▓░▓░▓░");

            Console.WriteLine("░▓░▓░▓░▓");

            Console.WriteLine("▓░▓░▓░▓░");

            Console.WriteLine("░▓░▓░▓░▓");

            Console.WriteLine("▓░▓░▓░▓░");

            Console.WriteLine("░▓░▓░▓░▓");

            Console.WriteLine("Line");

            int x, o, count;
            for (x = 1; x <= 8; x++)
            {
                if (x % 2 == 0) 
                { 
                    count = 1; 
                }
                else 
                { 
                    count = 0; 
                }

                for (o = 1; o <= 8; o++)

                {
                    if (o % 2 == count)
                    { 
                        Console.Write("▓▓");
                    }
                    else
                    { 
                        
                      Console.Write("░░"); 


                    }
                }
                Console.WriteLine();
            }

          






















        }
    }
}
