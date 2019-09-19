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
            if (Surtr.Location.Nepritel.prirodaCheck)
            {
                Message(prvni);
                Message(druhy);
                Surtr.Location.Nepritel.PrirodaFalse();
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
            if (Surtr.Location.Nepritel.specialCheck)
            {
                Message(prvni);
                Surtr.Location.Nepritel.SpecialFalse();
            }
            else Message(druhy);
        }

    }
}
