using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Menu
{
    class ZmenaLokace
    {
        Hero Surtr { get; set; }
        Bojiste[] seznamBojist { get; set; }

        public ZmenaLokace(Hero Surtr, Bojiste[] seznam)
        {
            this.Surtr = Surtr;
            seznamBojist = seznam;

        }


        public void ZmenmeLokaci ()
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
                }
                else if (zmenaMista == "") break;
                else Program.Message("\nZvol správnou možnost");
            }
        }
    }
}
