using Ragnarok.Menu.Boj.Specialni;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Menu.Boj
{
    class SpecialniMoznosti
    {
        Hero Surtr { get; set; }
        Inventar SurtruvInventar { get; set; }
        Bojiste Jih { get; set; }
        Bojiste Stred { get; set; }
        Bojiste Sever { get; set; }

        public SpecialniMoznosti(Hero surt,Inventar surtInv, Bojiste Jih, Bojiste Stred, Bojiste Sever)
        {
            Surtr = surt;
            SurtruvInventar = surtInv;
            this.Jih = Jih;
            this.Stred = Stred;
            this.Sever = Sever;
        }
        public static void Message(string text) { Console.WriteLine(text); Console.ReadLine(); }

        public void Specky()
        {
            bool go = true;
            while (go)
            {
                Console.Clear();
                Console.WriteLine($"\n1 - Použij něco z inventáře\n2 - Zkus využít krajinu ve svůj " +
                $"prospěch\n3 - Zkusíš něco spešl\n4 - Zpět v nabídce\n");
                string kreativniDecision = Console.ReadLine();
                switch (kreativniDecision)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\nTak copak to tu máme...");
                        SurtruvInventar.PodivejSeDoKapes();
                        string pocketDecision = Console.ReadLine();
                        if (int.TryParse(pocketDecision, out int result) && SurtruvInventar.Kapsy.ContainsKey(result))
                        {
                            go = SurtruvInventar.Pouzij(result, Surtr);
                        }
                        else Message("Zvol správnou možnost");
                        continue;

                    case "2":
                        Console.Clear();
                        if (Surtr.Location == Jih) Speciality.UdalostTypPriroda(Surtr, Texts.event1, Texts.event1_1, Texts.event1_2);
                        else if (Surtr.Location == Stred) Speciality.UdalostTypPriroda(Surtr, Texts.event2, Texts.event2_1);
                        else if (Surtr.Location == Sever) Speciality.UdalostTypPriroda(Surtr, Texts.event3, Texts.event3_1, Texts.event3_2);
                        break;

                    case "3":
                        Console.Clear();
                        if (Surtr.Location == Jih) Speciality.UdalostiTypSpecial(Surtr, Texts.event4, Texts.event4_1);
                        else Message("\nKde nic není, ani Surt nebere...");
                        continue;

                    case "4":
                        break;

                    default:
                        Message("Vyber správnou možnost.");
                        continue;
                }
                break;
            }
        }
    }
}
