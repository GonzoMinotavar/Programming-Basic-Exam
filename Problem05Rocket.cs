using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var outerDots = ((3 * n) - 2) / 2;
            var innerSymbols = 0;

            //first part
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', outerDots), new string(' ', innerSymbols));
                innerSymbols += 2;
                outerDots--;
            }

            outerDots = n / 2;
            innerSymbols = (3 * n) - n;

            Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('*', innerSymbols));

            innerSymbols = innerSymbols - 2;
            for (int i = 0; i < 2 * n; i++)
            {
                Console.WriteLine("{0}|{1}|{0}", new string('.', outerDots), new string('\\', innerSymbols));
            }

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', outerDots - i), new string('*', innerSymbols));
                innerSymbols += 2;
            }


            var = int.Parse(Console.ReadLine());
        }
    }
}
