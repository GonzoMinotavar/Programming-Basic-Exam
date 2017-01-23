using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var track = Console.ReadLine();

            var juniorsTax = 0.0;
            var seniorsTax = 0.0;

            switch(track.ToLower())
            {
                case "trail":
                    juniorsTax = 5.5;
                    seniorsTax = 7.00;
                    break;
                case "cross-country":

                    if(juniors + seniors >= 50)
                    {
                        juniorsTax = 8.00 * 0.75;
                        seniorsTax = 9.5 * 0.75;
                    }
                    else
                    {
                        juniorsTax = 8.00;
                        seniorsTax = 9.5;
                    }
                    break;
                case "downhill":
                    juniorsTax = 12.25;
                    seniorsTax = 13.75;
                    break;
                case "road":
                    juniorsTax = 20;
                    seniorsTax = 21.5;
                    break;

            }

            var sum = juniors*juniorsTax + seniors*seniorsTax;
            sum = sum*0.95;

            Console.WriteLine("{0:F2}",sum);
        }
    }
}
