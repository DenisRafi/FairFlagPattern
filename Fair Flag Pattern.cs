using System;

namespace Star_Pattern
{
    class ByDenisRafi
    {
        static void Main()
        {
            Console.Title = "Fair Flag Pattern";
            {
                int space = 0;
                int max = 10;

                for (var i = max; i > 0; i--)
                {
                    for (var j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    for (var j = 0; j < space; j++)
                    {
                        Console.Write(" ");
                    }
                    for (var j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    space += 2;
                }
                Console.ReadLine();
            }           
        }
    }
}

