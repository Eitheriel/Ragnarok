using System;
using System.Collections.Generic;
using System.Text;


namespace Ragnarok
{
    public class Program
    {
        static Dictionary<int, string> menuDict = new Dictionary<int, string>();

        public static void VypisMenu(List<string> menu1)
        {
            int i = 1;
            menuDict.Clear();
            foreach (string polozkaMenu in menu1)
            {
                menuDict.Add(i, polozkaMenu);
                Console.WriteLine($"{i} - {polozkaMenu}");
                i++;
                
            }
        }

        static void Main(string[] args)
        {
            /**********************
             * Inicializace armád *
             * ********************/
            Armada OhniviObri = new Armada("Ohniví Obři");
            Armada LedoviObri = new Armada("Ledoví obři", "zvejky", Texts.proLedove);
            Armada ArmadyHelu = new Armada("Armády říše Hell");
            Armada Elfove = new Armada("Elfové a trpaslíci");
            Armada Asgardane = new Armada("Asgarďané", "kondomy", Texts.proAsgard);
            Armada Einherjars = new Armada("Einherjars");

            /**********************
             * Přednastavení cílů *
             * ********************/
            Elfove.InventoryFalse();
            Asgardane.InventoryFalse();
            Asgardane.SpecialFalse();
            Einherjars.PrirodaFalse();
            Einherjars.SpecialFalse();

            /************************
             * Inicializace přírody *
             * **********************/

            Priroda Les = new Priroda("Les");
            Priroda More = new Priroda("Moře");
            Priroda Hory = new Priroda("Hory");

            /***********************
             * Inicializace bojišť *
             * *********************/

            Bojiste Jih = new Bojiste("Jih", Hory, OhniviObri, Elfove);
            Bojiste Stred = new Bojiste("Střed", Les, LedoviObri, Einherjars);
            Bojiste Sever = new Bojiste("Sever", More, ArmadyHelu, Asgardane);
            Bojiste[] seznamBojist = { Jih, Stred, Sever };

            /***********************
             * Inicializace hrdinů *
             * *********************/

            Hero Surtr = new Hero("Surtr", Jih);
            Hero Frey = new Hero("Frey", Jih);

            /*************************************
             * Inicializace předmětů v inventáři *
             * ***********************************/

            Inventar SurtruvInventar = new Inventar();
            Veci[] seznamVeci = { new Veci("Čtyři penny z výletu do Londýna", "money"),
                                  new Veci("Dávno prošlá krabička kondomů", "kondomy"),
                                  new Veci("Svačina z domova", "jidlo"),
                                  new Veci("Žvýkačky Winterfresh","zvejky")};
            SurtruvInventar.PridejDoKapes(seznamVeci);
            Veci mec = new Veci("Surtalogi", "Freyova hlava");

            /********
             * Menu *
             * ******/

            List<string> menu = new List<string> { "Půjdeš do boje!", "Půjdeš do jiné části bojiště", "Utkáš se s Freyem", "Zničíš celý svět" };
            //Využít statiku nebo ne?
            //ZabitFreye menuFrey = new ZabitFreye(Frey, menu, mec);
            //ZmenaLokace zmenaLok = new ZmenaLokace(Surtr, seznamBojist);
            Bojovani velkyBoj = new Bojovani(Surtr, SurtruvInventar, Jih, Stred, Sever);
            
            /********************
             * Textový úvod hry *
             * ******************/

            Console.WriteLine(Texts.gameLogo);
            Util.Message(Texts.intro1);
            Util.Message(Texts.intro2);

            Console.Clear();

            Util.Message(Texts.intro3);
            Util.Message(Texts.intro4);
            Util.Message(Texts.intro5);

            /***************
             * ZAČÁTEK HRY *
             * *************/

            bool go = true;
            while (go) {

                ///////////////
                //HLAVNÍ MENU//
                ///////////////

                Console.Clear();
                Console.WriteLine(" Co uděláš?\n ----------\n");
                VypisMenu(menu);
                Console.WriteLine("\nO=={::::::::::> <::::::::::}==O\n");
                string menuRozhodnuti = Console.ReadLine();

                if (int.TryParse(menuRozhodnuti, out int menuNumber) && menuDict.ContainsKey(menuNumber))
                {
                    Console.Clear();

                    //JÍT DO BOJE
                    if (menuDict[menuNumber] == "Půjdeš do boje!")
                    {
                        if (Surtr.Location.Active) velkyBoj.BojMenu();
                        else Util.Message("Už jsi zde úkol splnil a měl bys jít bojovat jinam.");
                    }

                    //ZMĚNIT LOKACI
                    else if (menuDict[menuNumber] == "Půjdeš do jiné části bojiště") ZmenaLokace.ZmenmeLokaci(Surtr, seznamBojist);

                    //ZABÍT FREYE
                    else if (menuDict[menuNumber] == "Utkáš se s Freyem") ZabitFreye.SmrtFreye(Frey,menu,mec);

                    //ZNIČIT CELÝ SVĚT
                    else if (menuDict[menuNumber] == "Zničíš celý svět")
                    {
                        if (!Jih.Active && !Sever.Active && !Stred.Active && !Frey.Alive)
                        {
                            Util.Message(Texts.end1);
                            Console.Clear();
                            Console.WriteLine(Texts.end2);
                            Util.Message(Texts.endPic);
                            break;
                        }
                        else Util.Message("\nJeště jsi nesplnil všechny úkoly.");
                    }
                }
                else
                {
                    Util.Message("\nZadej správné číslo.\n");
                    continue;
                }
            }
        }
    }
}

 