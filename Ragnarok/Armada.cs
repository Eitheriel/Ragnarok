using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Armada
    {
        public string jmenoArmady { get; }
        public bool nepritel { get; }
        public Armada (string jmeno, bool nepritel)
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
