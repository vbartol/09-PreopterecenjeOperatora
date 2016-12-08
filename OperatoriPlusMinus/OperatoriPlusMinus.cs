using System;

namespace Vsite.CSharp
{
    public struct KompleksniBroj
    {
        public double RealniDio;
        public double ImaginarniDio;

        public KompleksniBroj(double realniDio, double imaginarniDio)
        {
            RealniDio = realniDio;
            ImaginarniDio = imaginarniDio;
        }

        public override string ToString()
        {
            if (ImaginarniDio == 0)
                return RealniDio.ToString();
            if (RealniDio == 0)
                return PrikazImaginarnog();
            if (ImaginarniDio < 0)
                return string.Format("{0}{1}", RealniDio, PrikazImaginarnog());
            return string.Format("{0}+{1}", RealniDio, PrikazImaginarnog());
        }

        private string PrikazImaginarnog()
        {
            if (ImaginarniDio == 1)
                return "i";
            if (ImaginarniDio == -1)
                return "-i";
            return string.Format("{0}i", ImaginarniDio);
        }

        public static KompleksniBroj operator +(KompleksniBroj br1, KompleksniBroj br2)
        {
            //  implementirati binarni operator + (za zbrajanje dva kompleksna broja) i provjeriti ispis pri izvođenju programa
            return new KompleksniBroj(br1.RealniDio + br2.RealniDio, br1.ImaginarniDio + br2.ImaginarniDio);
            throw new NotImplementedException();
        }

        //  Implementirati binarni operator - (za oduzimanje dva kompleksna broja)
        public static KompleksniBroj operator -(KompleksniBroj br1, KompleksniBroj br2)
        {
           
            return new KompleksniBroj(br1.RealniDio - br2.RealniDio, br1.ImaginarniDio - br2.ImaginarniDio);
            
        }
        // TODO: Implementirati preopterećeni unarni operator - (za promjenu predznaka)
        public static KompleksniBroj operator -(KompleksniBroj br1)
        {

            return new KompleksniBroj(-br1.RealniDio,- br1.ImaginarniDio );
            
        }

        // TODO: Otkomentirati naredbu koja ga poziva u Main te provjeriti ispis pri izvođenju programa

    }

    class OperatoriPlusMinus
    {
        static void Main(string[] args)
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            KompleksniBroj kb2 = new KompleksniBroj(0, -4);

            KompleksniBroj zbroj = kb1 + kb2;
            Console.WriteLine("({0}) + ({1}) = {2}", kb1, kb2, zbroj);

            // Naredba koja poziva binarni operator -
            KompleksniBroj razlika = kb2 - kb1;
            Console.WriteLine("({0}) - ({1}) = {2}", kb1, kb2, razlika);

            // Naredba koja poziva unarni operator -
            Console.WriteLine("-[({0}) + ({1})] = {2}", kb1, kb2, -(zbroj));

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
