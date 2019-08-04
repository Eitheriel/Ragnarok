using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Veci
    {
        public string jmenoVeci { get; }
        public string ucelVeci { get; protected set; }

        public Veci(string vlozJmenoVeci,string heslo)
        {
            jmenoVeci = vlozJmenoVeci;
            ucelVeci = heslo;
        }

        /*public bool Pouzij(Veci veci)
        {
            return true;
        }*/

        public override string ToString()
        {
            return jmenoVeci;
        }

    }
}
