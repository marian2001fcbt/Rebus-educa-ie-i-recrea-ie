using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormularTaburiDinamice
{
    public static class Auxiliare
    {
        static int utilizatorLogat;
        public static int UtilizatorLogat
        {
            get { return utilizatorLogat; }
            set { utilizatorLogat = value; }
        }



        static int limba;
        public static int Limba
            {
                get { return limba; }
                set { limba = value; }   
            }


        static int iesire;
        public static int Iesire
        {
            get {return iesire;}
            set { iesire = value; }
        }
    }
}
