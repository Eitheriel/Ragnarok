using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Priroda
    {
        public string typ { get; }

        public Priroda (string nazevTypu)
        {
            typ = nazevTypu;
        }

        public override string ToString()
        {
            return typ;
        }
    }
}
