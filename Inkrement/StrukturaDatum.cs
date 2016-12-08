using System;

namespace Vsite.CSharp
{
    public struct StrukturaDatum
    {
        public StrukturaDatum(int godina, int mjesec, int dan) : this()
        {
            this.godina = godina;
            this.mjesec = mjesec;
            this.dan = dan;
        }

        public int Godina
        {
            get { return godina; }
        }

        public int Mjesec
        {
            get { return mjesec; }
        }

        public int Dan
        {
            get { return dan; }
        }

        private int godina;
        private int mjesec;
        private int dan;

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", Dan, Mjesec, Godina);
        }

        //definirati operator ++ koji će objekt tipa KlasaDatum uvećati za jedan dan, u metodi Main otkomentirati naredbe koje koriste operator ++ i pokrenuti program
        public static StrukturaDatum operator ++(StrukturaDatum datum)
        {
            Datum.UvećajDan(ref datum.dan, ref datum.mjesec, ref datum.godina);
            return datum;
        }
    }
}
