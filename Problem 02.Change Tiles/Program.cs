using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var Money = double.Parse(Console.ReadLine());
            var shirina = double.Parse(Console.ReadLine());
            var duljina = double.Parse(Console.ReadLine());
            var TriangleA = double.Parse(Console.ReadLine());
            var TriangleH = double.Parse(Console.ReadLine());
            var TrianglePrice = double.Parse(Console.ReadLine());
            var MaistorMoney = double.Parse(Console.ReadLine());

            var area = shirina * duljina;
            var TriangleArea = TriangleA * TriangleH / 2.00;
            var Triangles = Math.Ceiling(area / TriangleArea) + 5.00;
            var result = Triangles * TrianglePrice + MaistorMoney;


            if (result > Money)
            {
                Console.Write("You'll need {0:f2} lv more.", result - Money);
            }
            if (result <= Money)
            {
                Console.Write("{0:f2} lv left.", Money - result);
            }
        }
    }
}
