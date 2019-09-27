using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    static class ZmenaLokace
    {
        /*Hero Surtr { get; set; }
        Bojiste[] seznamBojist { get; set; }

        public ZmenaLokace(Hero Surtr, Bojiste[] seznam)
        {
            this.Surtr = Surtr;
            seznamBojist = seznam;

        }*/

        public static void ZmenmeLokaci (Hero Surtr,Bojiste[] seznamBojist)
        {
            while (true)
            {
                Console.WriteLine($"\nTvým bojištěm je nyní {Surtr.Location}. Můžeš si vybrat:\n\nBuď zůstaneš tam, kde jsi (zmáčkni Enter),\nnebo napiš do konzole místo, kam chceš jít:\n");

                Surtr.ZobrazBojiste(seznamBojist);
                Console.WriteLine("\n");
                string zmenaMista = Console.ReadLine();

                if (int.TryParse(zmenaMista, out int result) && Surtr.CeleBojiste.ContainsKey(result))
                {
                    Bojiste.ChangeLocation(Surtr.CeleBojiste[result], Surtr);
                    break;
                }
                else if (zmenaMista == "") break;
                else Util.Message("\nZvol správnou možnost");
            }
        }
    }
}
