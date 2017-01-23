using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallestRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var secondRoom = smallestRoom * 1.1;
            var thirdRoom = secondRoom*1.1;
            var bathroom = smallestRoom/2;

            var area = smallestRoom + kitchen + thirdRoom + bathroom + secondRoom;
            area = area + (5*area)/100;

            var finalPrice = area*price;

            Console.WriteLine("{0:F2}",finalPrice);
        }
    }
}
