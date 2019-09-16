using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Menu.Boj
{
    class Bojovani
    {
        Hero Surtr { get; set; }
        Inventar surtInv { get; set; }
        Bojiste Jih { get; set; }
        Bojiste Stred { get; set; }
        Bojiste Sever { get; set; }


        public Bojovani(Hero surt, Inventar surtInv, Bojiste Jih, Bojiste Stred, Bojiste Sever)
        {
            Surtr = surt;
            this.surtInv = surtInv;
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
                  $"zde tvoří {Surtr.Location.spojenec}, \nnepřítelem jsou ti {Surtr.Location.nepritel}. " +
                  $"Co se krajiny týče, vidíš zde {Surtr.Location.priroda}.");
                Console.WriteLine($"\nCo uděláš?\n\n" +
                    $"1 - Zaútočíš na tu trapnou armádu, kterou tvoří {Surtr.Location.nepritel}, přímo!\n" +
                    $"2 - Vymyslíš něco lepšího\n" +
                    $"3 - Odejdeš.\n");
                string coTed = Console.ReadLine();

                switch (coTed)
                {
                    //NAPADNOUT ARMÁDU
                    case "1":
                        if (Surtr.Location.nepritel.prirodaCheck == false && Surtr.Location.nepritel.inventoryCheck == false && Surtr.Location.nepritel.specialCheck == false)
                        {
                            Message("\nVyrazil jsi do útoku spolu se spojenci a oháněje se svým ohnivým mečem \nzabil jsi všechny nepřátele, až jsi zůstal na bojišti docela sám. Všichni spojenci padli v boji.");
                            Surtr.Location.setActiveFalse();
                            break;
                        }
                        else Message("\nNepřátelé jsou příliš silní, než abys je porazil. Budeš muset něco vymyslet...");
                        continue;

                    //VYMYSLET NĚCO LEPŠÍHO
                    case "2":
                        SpecialniMoznosti specMozn = new SpecialniMoznosti(Surtr, surtInv, Jih, Stred, Sever);
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
