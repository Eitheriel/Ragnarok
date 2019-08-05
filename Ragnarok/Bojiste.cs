using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Bojiste
    {
        public string castBojiste { get; }
        public bool active { get; private set; }

        public Bojiste (string cast, Priroda priroda, params Armada[] armada)
        {
            castBojiste = cast;
            active = true;
        }

        // když už bude lokace projitá (splněný úkol), přehodí se to na false, 
        // aby se ve switchi objevila hláška, že už je lokace projitá.
        public void setActiveFalse()
        {
            active = false;
        }

        public override string ToString()
        {
            return castBojiste;
        }
    }
}
