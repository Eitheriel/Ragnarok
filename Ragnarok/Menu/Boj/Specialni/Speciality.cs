using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    static class Speciality
    {
        public static void UdalostTypPriroda(Hero Surtr, string prvni, string druhy, string treti)
        {
            if (Surtr.Location.Nepritel.prirodaCheck)
            {
                Util.Message(prvni);
                Util.Message(druhy);
                Surtr.Location.Nepritel.PrirodaFalse();
            }
            else Util.Message(treti);
        }
        public static void UdalostTypPriroda(Hero Surtr, string prvni, string druhy)
        {
            Util.Message(prvni);
            Util.Message(druhy);
        }

        public static void UdalostiTypSpecial(Hero Surtr, string prvni, string druhy)
        {
            if (Surtr.Location.Nepritel.specialCheck)
            {
                Util.Message(prvni);
                Surtr.Location.Nepritel.SpecialFalse();
            }
            else Util.Message(druhy);
        }

    }
}
