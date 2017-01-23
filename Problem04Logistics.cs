using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var loadsSum = 0;

            var loadsWithBus = 0.0;
            var loadsWithTruck = 0.0;
            var loadsWithTrain = 0.0;
            

            for (int i = 0; i < count; i++)
            {
                var load = int.Parse(Console.ReadLine());
                loadsSum += load;

                if (load < 4)
                {
                    loadsWithBus += load;
                } 
                else if (load > 3 && load < 12)
                {
                    loadsWithTruck += load;
                }
                else
                {
                    loadsWithTrain += load;
                }
            }

            var average = (loadsWithBus * 200 + loadsWithTruck * 175 + loadsWithTrain * 120)/
            loadsSum;

            Console.WriteLine("{0:F2}",average);

            Console.WriteLine("{0:F2}%",loadsWithBus / loadsSum * 100);
            Console.WriteLine("{0:F2}%", loadsWithTruck / loadsSum * 100);
            Console.WriteLine("{0:F2}%", loadsWithTrain / loadsSum * 100);


        }
    }
}
