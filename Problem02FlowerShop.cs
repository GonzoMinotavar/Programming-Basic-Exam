using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolies = 3.25;
            var hyacinth = 4.00;
            var roses = 3.5;
            var cactuses = 8.00;

            var countMagnolies = int.Parse(Console.ReadLine());
            var countHyacinth = int.Parse(Console.ReadLine());
            var countRoses = int.Parse(Console.ReadLine());
            var countCactuses = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var sum = countMagnolies * magnolies + countHyacinth * hyacinth +
                      countRoses * roses + countCactuses * cactuses;

            var result = sum * 0.95;

            //var tax = sum * 0.05;
            //var result = sum - tax;

            if (result >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(result - giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva." , Math.Ceiling(giftPrice - result));
            }

        }
    }
}
