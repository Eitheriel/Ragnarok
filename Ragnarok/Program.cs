﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Ragnarok
{
    class Program
    {
        public static void Message(string text) {Console.WriteLine(text); Console.ReadLine();}

        static void Main(string[] args)
        {
            Armada OhniviObri= new Armada("Ohniví Obři", "nic", Texts.proZbytek);
            Armada LedoviObri = new Armada("Ledoví obři", "zvejky", Texts.proLedove);
            Armada ArmadyHelu = new Armada("Armády říše Hell", "nic", Texts.proZbytek);
            Armada Elfove = new Armada("Elfové a trpaslíci", "nic", Texts.proZbytek);
            Armada Asgardane = new Armada("Asgarďané", "kondomy", Texts.proAsgard);
            Armada Einherjars = new Armada("Einherjars", "nic", Texts.proZbytek);

            //Prednastavení cílů
            Elfove.InventoryFalse();
            Asgardane.InventoryFalse();
            Asgardane.SpecialFalse();
            Einherjars.PrirodaFalse();
            Einherjars.SpecialFalse();

            Priroda Les = new Priroda("Les");
            Priroda More = new Priroda("Moře");
            Priroda Hory = new Priroda("Hory");

            Bojiste Jih = new Bojiste("Jih", Hory, OhniviObri, Elfove);
            Bojiste Stred = new Bojiste("Střed", Les, LedoviObri, Einherjars);
            Bojiste Sever = new Bojiste("Sever", More, ArmadyHelu, Asgardane);
            Bojiste[] seznamBojist = { Jih, Stred, Sever };
            

            Hero Surtr = new Hero("Surtr", Jih);
            Hero Frey = new Hero("Frey", Jih);

            Veci[] seznamVeci = { new Veci("Čtyři penny z výletu do Londýna", "money"),
                new Veci("Dávno prošlá krabička kondomů", "kondomy"),
                new Veci("Svačina z domova", "jidlo"),
                new Veci("Žvýkačky Winterfresh","zvejky")};

            Surtr.PridejDoKapes(seznamVeci);

            Veci mec = new Veci("Surtalogi", "Freyova hlava");

            List<string> menu = new List<string> {"1 - Půjdeš do boje!", "2 - Půjdeš do jiné části bojiště", "3 - Utkáš se s Freyem"};

            Console.WriteLine(Texts.gameLogo);
            Message(Texts.intro1);
            Message(Texts.intro2);

            Console.Clear();

            Message(Texts.intro3);
            Message(Texts.intro4);
            Message(Texts.intro5);

            bool go = true;

            while (go) {

                while (true)
                {
                    if (!Sever.active && !Stred.active && !Jih.active && !Frey.alive)
                    {
                        menu.Add("3 - Zničíš celý svět");
                    }

                    //HLAVNÍ MENU
                    Console.Clear();
                    Console.WriteLine(" Co uděláš?\n ----------\n");
                    menu.ForEach(x => Console.WriteLine(x));
                    Console.WriteLine("\nO=={::::::::::> <::::::::::}==O\n");
                    string rozhodnuti = Console.ReadLine();

                    switch (rozhodnuti)
                    {
                        //JÍT DO BOJE
                        case "1":
                            Console.Clear();
                            if (Surtr.Location.active)
                            {
                                Console.WriteLine($"\n{Surtr.Location} je plný bojů! Tvou část armády " +
                                                  $"zde tvoří {Surtr.Location.spojenec}, \nnepřítelem jsou ti {Surtr.Location.nepritel}. " +
                                                  $"Co se krajiny týče, vidíš zde {Surtr.Location.priroda}.");

                                while (true)
                                {
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
                                            while (true)
                                            {
                                            Console.WriteLine($"\n1 - Použij něco z inventáře\n2 - Zkus využít krajinu ve svůj " +
                                            $"prospěch\n3 - Zkusíš něco spešl\n4 - Zpět v nabídce\n");
                                                string kreativniDecision = Console.ReadLine();
                                                switch (kreativniDecision)
                                                {
                                                    case "1":
                                                        Console.Clear();
                                                        Console.WriteLine("\nTak copak to tu máme...");
                                                        Surtr.PodivejSeDoKapes();
                                                        string pocketDecision = Console.ReadLine();
                                                        if (int.TryParse(pocketDecision, out int result) && Surtr.Kapsy.ContainsKey(result))
                                                        {
                                                            Surtr.Pouzij(result, Surtr);
                                                        }
                                                        else Message("Zvol správnou možnost");
                                                        continue;

                                                    case "2":
                                                        Console.Clear();
                                                        if (Surtr.Location == Jih)
                                                        {
                                                            if (Surtr.Location.nepritel.prirodaCheck)
                                                            {
                                                                Message(Texts.event1);
                                                                Message("Nechytil.");
                                                                Surtr.Location.nepritel.PrirodaFalse();
                                                            }
                                                            else Message("\nUž nemáš žádné hory, které bys trpaslíkům vmetl do tváře.");
                                                            
                                                        }

                                                        else if (Surtr.Location == Stred)
                                                        {
                                                            Message(Texts.event2);
                                                            Message("\nNo ale to je ti teď stejně k hovnu.");
                                                        }

                                                        else
                                                        {
                                                            if (Surtr.Location.nepritel.prirodaCheck)
                                                            {
                                                                Message("\nJéé, moře! U moře už jsi nebyl ani nepamatuješ! Sundal sis kaťata a hupsnul do vln!");
                                                                Message(Texts.event3);
                                                                Surtr.Location.nepritel.PrirodaFalse();
                                                            }
                                                            else Message("\nUž ne, už jsi nadělal dost škody na morálce nepřátel.");
                                                        }
                                                        break;

                                                    case "3":
                                                        Console.Clear();
                                                        if (Surtr.Location == Jih)
                                                            {
                                                                if (Surtr.Location.nepritel.specialCheck)
                                                                {
                                                                    Message(Texts.event4);
                                                                    Surtr.Location.nepritel.SpecialFalse();
                                                                }
                                                                else Message("\nSvým strašným zpěvem jsi již zastavil útok elfů. Není potřeba dál děsit i vlastní muže.");
                                                            }
                                                        else Message("\nKde nic není, ani Surt nebere...");
                                                        break;

                                                    case "4":
                                                        break;

                                                    default:
                                                        Message("Vyber správnou možnost.");
                                                        continue;
                                                }
                                                break;
                                            }
                                            continue;

                                        //ODEJÍT
                                        case "3":
                                            break;

                                        default:
                                            Message("\nVyber správnou možnost.");
                                            continue;
                                    }
                                    break;
                                }
                            }
                            else Message("Už jsi zde úkol splnil a měl bys jít bojovat jinam.");
                            break;

                        //ZMĚNIT LOKACI
                        case "2":
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine($"\nTvým bojištěm je nyní {Surtr.Location}. Můžeš si vybrat:\n\nBuď zůstaneš tam, kde jsi (zmáčkni Enter),\nnebo napiš do konzole místo, kam chceš jít:\n");

                                Surtr.PodivejSePoBojisti(seznamBojist);
                                Console.WriteLine("\n");
                                string zmenaMista = Console.ReadLine();

                                if (int.TryParse(zmenaMista, out int result) && Surtr.CeleBojiste.ContainsKey(result))
                                {
                                    Bojiste.ChangeLocation(Surtr.CeleBojiste[result], Surtr);
                                }
                                else Message("Zvol správnou možnost");
                                break;

                            }
                            break;

                        //ZABÍT FREYE/ZAHÁJIT KONEC SVĚTA
                        case "3":
                            Console.Clear();

                            if (Frey.alive)
                            {
                                Message($"\nPo úvodu bitvy se postavíš jednomu z hlavních bohů - {Frey}ovi. Víš, že\n" +
                                    $"u sebe nemá zbraň - kouzelný meč, kterého se vzdal kvůli své lásce.");
                                Console.WriteLine(Texts.frey1);
                                while (true)
                                {
                                    string tezkeRozhodnuti = Console.ReadLine();
                                    switch (tezkeRozhodnuti)
                                    {
                                        case "1":
                                            Console.WriteLine($"\nZaútočil jsi na {Frey}e a s obří silou jsi ho svým ohnivým mečem {mec}m \nrozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                                            Message(Texts.freyFire);
                                            Frey.setDead();
                                            menu.Remove("3 - Utkáš se s Freyem");
                                            break;

                                        case "2":
                                            Message($"\nNasral jsi ho.");
                                            Console.WriteLine($"\nPak jsi ho svým ohnivým mečem rozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                                            Message(Texts.freyFire);
                                            Frey.setDead();
                                            menu.Remove("3 - Utkáš se s Freyem");
                                            break;
                                        default:
                                            continue;
                                    }
                                    break;
                                }
                            }

                            else if (!Jih.active && !Sever.active && !Stred.active && !Frey.alive)
                            {
                                Message(Texts.end1);
                                Console.Clear();
                                Console.WriteLine(Texts.end2);
                                Message(Texts.endPic);
                                go = false;
                                break;
                            }

                            else
                            {
                                Message("\nZadej správné číslo.\n");
                                continue;
                            }
                            break;

                        default:
                            Message("\nZadej správné číslo.\n");
                            continue;             
                    }
                    break;
                }
            }
        }
    }
}