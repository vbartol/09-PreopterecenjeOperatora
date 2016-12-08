using System;
using System.Diagnostics;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StrukturaDatum:");

            StrukturaDatum sd = new StrukturaDatum(2015, 12, 31);

            StrukturaDatum sdPrefix = ++sd;
            Console.WriteLine(sdPrefix);
            Console.WriteLine(sd);

            StrukturaDatum sdPostfix = sd++;
            Console.WriteLine(sdPostfix);
            Console.WriteLine(sd);

            
            Console.WriteLine("KlasaDatum:");

            KlasaDatum kd = new KlasaDatum(2016, 2, 28);

            KlasaDatum kd2 = null;
            kd2 = ++kd;
            Console.WriteLine(kd2);
            
            KlasaDatum kd3 = null;
            kd3 = kd++;
            Console.WriteLine(kd3);

            Console.WriteLine(kd);
            Console.WriteLine(kd2);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
