using System;
using System.Globalization;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do trigangulo X");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do trigangulo Y");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;

            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));


            Console.WriteLine("Area de x =" + areaX.ToString("f4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de y =" + areaY.ToString("f4", CultureInfo.InvariantCulture));



            if (areaX > areaY)
            {
                Console.WriteLine("A area x é maior");
            }
            else
            {
                Console.WriteLine("A area x é maior");

            }


        }
    }
}
