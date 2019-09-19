using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Menu.Boj
{
    class Bojovani
    {
        Hero Surtr { get; set; }
        Inventar SurtInv { get; set; }
        Bojiste Jih { get; set; }
        Bojiste Stred { get; set; }
        Bojiste Sever { get; set; }

        public Bojovani(Hero surt, Inventar surtInv, Bojiste Jih, Bojiste Stred, Bojiste Sever)
        {
            Surtr = surt;
            this.SurtInv = surtInv;
            this.Jih = Jih;
            this.Stred = Stred;
            this.Sever = Sever;
        }

        public static void Message(string text) { Console.WriteLine(text); Console.ReadLine(); }
        public void BojMenu()
        {
            bool go = true;
            while (go)
            {
                Console.Clear();
                Console.WriteLine($"\n{Surtr.Location} je plný bojů! Tvou část armády " +
                  $"zde tvoří {Surtr.Location.Spojenec}, \nnepřítelem jsou ti {Surtr.Location.Nepritel}. " +
                  $"Co se krajiny týče, vidíš zde {Surtr.Location.Priroda}.");
                Console.WriteLine($"\nCo uděláš?\n\n" +
                    $"1 - Zaútočíš na tu trapnou armádu, kterou tvoří {Surtr.Location.Nepritel}, přímo!\n" +
                    $"2 - Vymyslíš něco lepšího\n" +
                    $"3 - Odejdeš.\n");
                string coTed = Console.ReadLine();

                switch (coTed)
                {
                    //NAPADNOUT ARMÁDU
                    case "1":
                        if (Surtr.Location.Nepritel.prirodaCheck == false && Surtr.Location.Nepritel.inventoryCheck == false && Surtr.Location.Nepritel.specialCheck == false)
                        {
                            Message("\nVyrazil jsi do útoku spolu se spojenci a oháněje se svým ohnivým mečem \nzabil jsi všechny nepřátele, až jsi zůstal na bojišti docela sám. Všichni spojenci padli v boji.");
                            Surtr.Location.SetActiveFalse();
                            go = false;
                            break;
                        }
                        else Message("\nNepřátelé jsou příliš silní, než abys je porazil. Budeš muset něco vymyslet...");
                        continue;

                    //VYMYSLET NĚCO LEPŠÍHO
                    case "2":
                        SpecialniMoznosti specMozn = new SpecialniMoznosti(Surtr, SurtInv, Jih, Stred, Sever);
                        specMozn.Specky();
                        continue;

                    //ODEJÍT
                    case "3":
                        go = false;
                        break;
                }
                continue;
            }
        }
    }
}
