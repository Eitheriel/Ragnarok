using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Armada
    {
        public string jmenoArmady { get; }
        public bool nepritel { get; }

        public string heslo { get; }
        public Armada (string jmeno, bool nepritel, string heslo)
        {
            jmenoArmady = jmeno;
            this.nepritel = nepritel;
        }

        public override string ToString()
        {
            return jmenoArmady;
        }
    }
}
