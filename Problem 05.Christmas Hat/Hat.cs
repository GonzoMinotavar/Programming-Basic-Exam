using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class Hat
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var outerDots = n * 2 - 1;

            var innerSymbols = 0;
            Console.WriteLine("{0}/{1}\\{0}", new string('.', (2 * n) - 1 ), new string('|', 1));
            Console.WriteLine("{0}\\{1}/{0}", new string('.', (2 * n) - 1 ), new string('|', 1));
            //     Console.WriteLine("{0}{1}{0}", new string('.', (2 * n) - 2), new string('*', 3));

            for (int i = 0; i < n * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outerDots), new string('-', innerSymbols));
                outerDots--;
                innerSymbols++;

            }
            Console.WriteLine(new string('*', 4 * n + 1));

            for (int i = 0; i < n * 2; i++)
            {
                Console.Write("*");
                Console.Write(".");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));
            Console.ReadLine();


        }
    }
}
