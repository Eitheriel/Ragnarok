using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Priroda
    {
        public string Typ { get; }

        public Priroda (string nazevTypu)
        {
            Typ = nazevTypu;
        }

        public override string ToString() => Typ;
    }
}
