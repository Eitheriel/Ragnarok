using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Menu.Boj.Specialni
{
    static class Speciality
    {
        public static void Message(string text) { Console.WriteLine(text); Console.ReadLine(); }

        public static void UdalostTypPriroda(Hero Surtr, string prvni, string druhy, string treti)
        {
            if (Surtr.Location.nepritel.prirodaCheck)
            {
                Message(prvni);
                Message(druhy);
                Surtr.Location.nepritel.PrirodaFalse();
            }
            else Message(treti);
        }
        public static void UdalostTypPriroda(Hero Surtr, string prvni, string druhy)
        {
            Message(prvni);
            Message(druhy);
        }

        public static void UdalostiTypSpecial(Hero Surtr, string prvni, string druhy)
        {
            if (Surtr.Location.nepritel.specialCheck)
            {
                Message(prvni);
                Surtr.Location.nepritel.SpecialFalse();
            }
            else Message(druhy);
        }

    }
}
