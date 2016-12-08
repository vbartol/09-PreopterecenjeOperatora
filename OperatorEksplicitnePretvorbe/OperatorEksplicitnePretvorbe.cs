using System;
using System.Diagnostics;

namespace Vsite.CSharp
{

    //  U strukturi Racionalni iz prethodnog projekta definirati javnu (public) metodu pretvorbe ToDouble() koja će racionalni broj pretvoriti u double i to vratiti kao rezultat


    //  U strukturi Racionalni iz prethodnog projekta definirati operator eksplicitne pretvorbe u double (koji poziva gornju metodu ToDouble)


    // U strukturi Racionalni iz prethodnog projekta definirati javnu (public) metodu pretvorbe ToInt64() koja će racionalni broj pretvoriti u long i to vratiti kao rezultat


    //  U strukturi Racionalni iz prethodnog projekta definirati operator eksplicitne pretvorbe u long (koji poziva gornju metodu ToInt64)


    //  Otkomentirati donje naredbe i provjeriti ispis

    class Program
    {
        static void Main(string[] args)
        {
            Racionalni rac = new Racionalni(2, 3);
            // eksplicitna pretvorba
            long racKaoInt = (long)rac;
            Console.WriteLine(racKaoInt);

            double racKaoDouble = (double)rac;
            Console.WriteLine(racKaoDouble);

            Console.WriteLine("GOTOVO!!!!");
            Console.ReadKey();
        }
    }
}
