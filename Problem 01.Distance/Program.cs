using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace FirstProblem

{

    class Program

    {

        static void Main(string[] args)

        {

            var speed = int.Parse(Console.ReadLine());
            var FirstTime = int.Parse(Console.ReadLine());
            var SecondTime = int.Parse(Console.ReadLine());
            var ThirdTime = int.Parse(Console.ReadLine());

            double FirstKm = speed * (FirstTime / 60.00);
            double Speed1 = speed * 1.10 * (SecondTime / 60.00);
            double Speed2 = (speed * 1.10) * 0.95 * (ThirdTime / 60.00);

            var result = FirstKm + Speed1 + Speed2;

            Console.WriteLine("{0:f2}", result);

        }

    }
}
