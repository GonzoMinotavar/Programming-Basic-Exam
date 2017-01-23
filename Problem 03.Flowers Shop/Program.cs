using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hrizantemi = int.Parse(Console.ReadLine());
            var Roses = int.Parse(Console.ReadLine());
            var Laleta = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var praznik = Console.ReadLine();

            var HrizantemiPrice = 0.00;
            var rosesPrice = 0.00;
            var LaletaPrice = 0.00;

            var flowersCount = Roses + Laleta + Hrizantemi;
            var FlowersPrice = 0.00;
            switch (season)
            {
                case "Winter":
                    HrizantemiPrice = 3.75;
                    rosesPrice = 4.50;
                    LaletaPrice = 4.15;
                    break;

                case "Spring":
                    HrizantemiPrice = 2.00;
                    rosesPrice = 4.10;
                    LaletaPrice = 2.50;  
                    break;
                case "Summer":
                    HrizantemiPrice = 2.00;
                    rosesPrice = 4.10;
                    LaletaPrice = 2.50;
                    break;
                case "Autumn":
                    HrizantemiPrice = 3.75;
                    rosesPrice = 4.50;
                    LaletaPrice = 4.15;
                    break;
            }
            

            FlowersPrice = (Laleta * LaletaPrice) + (Roses * rosesPrice) + (Hrizantemi * HrizantemiPrice);

            if (praznik == "Y")
            {
                FlowersPrice = FlowersPrice * 1.15;
            }

            if (season == "Spring" && Laleta > 7)
            {
                FlowersPrice = FlowersPrice * 0.95;
            }


            if (season == "Winter" && Roses >= 10)
            {
                FlowersPrice = FlowersPrice * 0.90;
            }

            if (flowersCount > 20)
            {
                FlowersPrice = FlowersPrice * 0.80;
            }

            Console.WriteLine("{0:f2}",FlowersPrice + 2); 
           
            
           



        }
    }
}
6