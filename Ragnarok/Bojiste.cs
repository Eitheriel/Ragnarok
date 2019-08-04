using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    class Bojiste
    {
        public string castBojiste { get; }

        public Bojiste (string cast, Priroda priroda, params Armada[] armada)
        {
            castBojiste = cast;
        }

        public override string ToString()
        {
            return castBojiste;
        }
    }
}
