using System;
using System.Collections.Generic;
using System.Text;


namespace Ragnarok
{
    class Program
    {
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

            Surtr.CoMasPoKapsach.Add(new Veci("Čtyři penny z výletu do Londýna","money"));
            Surtr.CoMasPoKapsach.Add(new Veci("Dávno prošlá krabička kondomů","kondomy"));
            Surtr.CoMasPoKapsach.Add(new Veci("Svačina z domova","jidlo"));
            Surtr.CoMasPoKapsach.Add(new Veci("Žvýkačky Winterfresh","zvejky"));
            Veci mec = new Veci("Surtalogi", "Freyova hlava");

            List<string> menu = new List<string> {"1 - Půjdeš do boje!", "2 - Půjdeš do jiné části bojiště", "3 - Utkáš se s Freyem"};

            Console.WriteLine(Texts.gameLogo);
            Console.WriteLine(Texts.intro1);
            Console.ReadLine();
            Console.WriteLine(Texts.intro2);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(Texts.intro3);
            Console.ReadLine();
            Console.WriteLine(Texts.intro4);
            Console.ReadLine();
            Console.WriteLine(Texts.intro5);
            Console.ReadLine();

            bool go = true;


            while (go) {

                while (true)
                {
                    if (!Jih.active && !Sever.active && !Stred.active && !Frey.alive && !menu.Contains("3 - Zničíš celý svět"))
                    {
                        menu.Add("3 - Zničíš celý svět");
                    }

                    Console.Clear();
                    Console.WriteLine(" Co uděláš?\n ----------\n");
                    menu.ForEach(x => Console.WriteLine(x));
                    Console.WriteLine("\nO=={::::::::::> <::::::::::}==O\n");
                    string rozhodnuti = Console.ReadLine();

                    switch (rozhodnuti)
                    {
                        case "1":
                            Console.Clear();
                            if (Surtr.Location.active)
                            {
                                Console.WriteLine($"\n{Surtr.Location} je plný bojů! Tvou část armády " +
                                        $"zde tvoří {Surtr.Location.spojenec}, \nnepřítelem jsou ti {Surtr.Location.nepritel}. " +
                                        $"Co se krajiny týče, vidíš zde {Surtr.Location.priroda}.");
                                Console.ReadLine();

                                while (true)
                                {
                                    Console.Clear();
                                    Console.WriteLine($"\nCo uděláš?\n\n" +
                                        $"1 - Zaútočíš na tu trapnou armádu, kterou tvoří {Surtr.Location.nepritel}, přímo!\n" +
                                        $"2 - Vymyslíš něco lepšího\n" +
                                        $"3 - Odejdeš.\n");
                                    string coTed = Console.ReadLine();

                                    switch (coTed)
                                    {
                                        case "1":
                                            if (Surtr.Location.nepritel.prirodaCheck == false && Surtr.Location.nepritel.inventoryCheck == false && Surtr.Location.nepritel.specialCheck == false)
                                            {
                                                Console.WriteLine("\nVyrazil jsi do útoku spolu se spojenci a oháněje se svým ohnivým mečem \nzabil jsi všechny nepřátele, až jsi zůstal na bojišti docela sám. Všichni spojenci padli v boji.");
                                                Surtr.Location.setActiveFalse();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nNepřátelé jsou příliš silní, než abys je porazil. Budeš muset něco vymyslet...");
                                                Console.ReadLine();
                                            }
                                            continue;

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
                                                            for (int i = 1; i < Surtr.CoMasPoKapsach.Count + 1; i++)
                                                            {
                                                                Console.WriteLine($"{i} - {Surtr.CoMasPoKapsach[i - 1]}");
                                                            }
                                                            string pocketDecision = Console.ReadLine();
                                                            switch (pocketDecision)
                                                            {
                                                                case "1":
                                                                    if (Surtr.CoMasPoKapsach[0].ucelVeci == Surtr.Location.nepritel.heslo)
                                                                    {
                                                                        Console.WriteLine(Surtr.Location.nepritel.message);
                                                                        Surtr.Location.nepritel.InventoryFalse();
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    break;
                                                                    }
                                                                    else if (Surtr.CoMasPoKapsach[0].ucelVeci == Surtr.Location.spojenec.heslo)
                                                                    {
                                                                        Console.WriteLine(Surtr.Location.spojenec.message);
                                                                        Surtr.Location.nepritel.InventoryFalse();
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    break;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nNic zvláštního se nestalo.");
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    continue;
                                                                    }


                                                                case "2":
                                                                    if (Surtr.CoMasPoKapsach[1].ucelVeci == Surtr.Location.nepritel.heslo)
                                                                    {
                                                                        Console.WriteLine(Surtr.Location.nepritel.message);
                                                                        Surtr.Location.nepritel.InventoryFalse();
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    break;
                                                                    }
                                                                    else if (Surtr.CoMasPoKapsach[1].ucelVeci == Surtr.Location.spojenec.heslo)
                                                                    {
                                                                        Console.WriteLine(Surtr.Location.spojenec.message);
                                                                        Surtr.Location.nepritel.InventoryFalse();
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    break;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nNic zvláštního se nestalo.");
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    continue;
                                                                    }


                                                                case "3":
                                                                    if (Surtr.CoMasPoKapsach[2].ucelVeci == Surtr.Location.nepritel.heslo)
                                                                    {
                                                                        Console.WriteLine(Surtr.Location.nepritel.message);
                                                                        Surtr.Location.nepritel.InventoryFalse();
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    break;
                                                                    }
                                                                    else if (Surtr.CoMasPoKapsach[2].ucelVeci == Surtr.Location.spojenec.heslo)
                                                                    {
                                                                        Console.WriteLine(Surtr.Location.spojenec.message);
                                                                        Surtr.Location.nepritel.InventoryFalse();
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    break;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nNic zvláštního se nestalo.");
                                                                        Console.ReadLine();
                                                                        Console.Clear();
                                                                    continue;
                                                                    }


                                                                case "4":
                                                                    if (Surtr.CoMasPoKapsach.Count > 3)
                                                                    {
                                                                        if (Surtr.CoMasPoKapsach[3].ucelVeci.Equals(Surtr.Location.nepritel.heslo))
                                                                        {
                                                                            Console.WriteLine(Surtr.Location.nepritel.message);
                                                                            Surtr.VecJePryc(Surtr.CoMasPoKapsach[3]);
                                                                            Surtr.Location.nepritel.InventoryFalse();
                                                                            Console.ReadLine();
                                                                            Console.Clear();
                                                                        break;
                                                                        }
                                                                        else if (Surtr.CoMasPoKapsach[3].ucelVeci.Equals(Surtr.Location.spojenec.heslo))
                                                                        {
                                                                            Console.WriteLine(Surtr.Location.spojenec.message);
                                                                            Surtr.VecJePryc(Surtr.CoMasPoKapsach[3]);
                                                                            Surtr.Location.nepritel.InventoryFalse();
                                                                            Console.ReadLine();
                                                                            Console.Clear();
                                                                        break;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("\nNic zvláštního se nestalo.");
                                                                            Console.ReadLine();
                                                                            Console.Clear();
                                                                        continue;
                                                                        }


                                                                    }
                                                                    else Console.WriteLine("\nVyber z nabízených možností");
                                                                    Console.Clear();
                                                                    continue;

                                                                default:
                                                                    Console.WriteLine("\nVyber z nabízených možností");
                                                                    Console.Clear();
                                                                    continue;
                                                            }
                                                            continue;

                                                        case "2":
                                                        Console.Clear();
                                                        if (Surtr.Location == Jih)
                                                            {
                                                                if (Surtr.Location.nepritel.prirodaCheck)
                                                                {
                                                                    Console.WriteLine(Texts.event1);
                                                                    Console.ReadLine();
                                                                    Console.WriteLine("Nechytil.");
                                                                    Surtr.Location.nepritel.PrirodaFalse();
                                                                    Console.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\nUž nemáš žádné hory, které bys trpaslíkům vmetl do tváře.");
                                                                    Console.ReadLine();
                                                                }
                                                            }

                                                            else if (Surtr.Location == Stred)
                                                            {
                                                                Console.WriteLine(Texts.event2);
                                                                Console.ReadLine();
                                                                Console.WriteLine("\nNo ale to je ti teď stejně k hovnu.");
                                                                Console.ReadLine();
                                                            }

                                                            else
                                                            {
                                                                if (Surtr.Location.nepritel.prirodaCheck)
                                                                {
                                                                    Console.WriteLine("\nJéé, moře! U moře už jsi nebyl ani nepamatuješ! Sundal sis kaťata a hupsnul do vln!");
                                                                    Console.ReadLine();
                                                                    Console.WriteLine(Texts.event3);
                                                                    Surtr.Location.nepritel.PrirodaFalse();
                                                                    Console.ReadLine();
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\nUž ne, už jsi nadělal dost škody na morálce nepřátel.");
                                                                    Console.ReadLine();
                                                                }
                                                            }
                                                            break;

                                                        case "3":
                                                        Console.Clear();
                                                        if (Surtr.Location == Jih)
                                                            {
                                                                if (Surtr.Location.nepritel.specialCheck)
                                                                {
                                                                    Console.WriteLine(Texts.event4);
                                                                    Console.ReadLine();
                                                                    Surtr.Location.nepritel.SpecialFalse();
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("\nSvým strašným zpěvem jsi již zastavil útok elfů. Není potřeba dál děsit i vlastní muže.");
                                                                    Console.ReadLine();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("\nKde nic není, ani Surt nebere...");
                                                                Console.ReadLine();
                                                            }
                                                            break;

                                                        case "4":
                                                            break;

                                                        default:
                                                            Console.WriteLine("\nVyber správnou možnost.");
                                                            continue;
                                                    }
                                                break;
                                                }
                                            continue;
                                        case "3":
                                            break;

                                        default:
                                            Console.WriteLine("\nVyber správnou možnost.");
                                            continue;
                                    }
                                    break;
                                }
                            }
                            else
                                Console.WriteLine("Už jsi zde úkol splnil a měl bys jít bojovat jinam.");
                                Console.ReadLine();

                            break;

                        case "2":
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine($"\nTvým bojištěm je nyní {Surtr.Location}. Můžeš si vybrat:\n\nBuď zůstaneš tam, kde jsi (zmáčkni Enter),\nnebo napiš do konzole místo, kam chceš jít:\n");

                                foreach (Bojiste b in seznamBojist)
                                {
                                    if (b != Surtr.Location)
                                        Console.WriteLine(b);
                                }
                                Console.WriteLine("\n");
                                string zmenaMista = Console.ReadLine();

                                switch (zmenaMista)
                                {
                                    case "Jih": case "jih":
                                        if (Jih.active)
                                        {
                                            Surtr.setLocation(Jih);
                                            Console.WriteLine($"\nPřesunul ses do lokace {Surtr.Location}.");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Na jihu už jsi vše splnil, nemáš důvod se tam vracet.");
                                            Console.ReadLine();
                                        }
                                        break;

                                    case "Stred": case "stred": case "Střed": case "střed":
                                        if (Stred.active)
                                        {
                                            Surtr.setLocation(Stred);
                                            Console.WriteLine($"\nPřesunul ses do lokace {Surtr.Location}");
                                            Console.ReadLine();
                                        }

                                        else
                                        {
                                            Console.WriteLine("Ve středu bojiště už jsi vše splnil, nemáš důvod se tam vracet.");
                                            Console.ReadLine();
                                        }
                                        break;


                                    case "Sever": case "sever":
                                        if (Sever.active)
                                        {
                                            Surtr.setLocation(Sever);
                                            Console.WriteLine($"\nPřesunul ses do lokace {Surtr.Location}");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nNa severu už jsi vše splnil, nemáš důvod se tam vracet.");
                                            Console.ReadLine();
                                        }
                                        break;

                                    case "":
                                        break;

                                    default:
                                        Console.WriteLine("\nZadej správné umístění.");
                                        continue;
                                }
                                break;

                            }
                            break;

                        case "3":
                            Console.Clear();

                            if (Frey.alive)
                            {
                                Console.Clear();
                                Console.WriteLine($"\nPo úvodu bitvy se postavíš jednomu z hlavních bohů - {Frey}ovi. Víš, že\n" +
                                    $"u sebe nemá zbraň - kouzelný meč, kterého se vzdal kvůli své lásce.");
                                Console.ReadLine();
                                Console.WriteLine(Texts.frey1);
                                while (true)
                                {
                                    string tezkeRozhodnuti = Console.ReadLine();
                                    switch (tezkeRozhodnuti)
                                    {
                                        case "1":
                                            Console.WriteLine($"\nZaútočil jsi na {Frey}e a s obří silou jsi ho svým ohnivým mečem {mec}m \nrozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                                            Console.WriteLine(Texts.freyFire);
                                            Frey.setDead();
                                            menu.Remove("3 - Utkáš se s Freyem");
                                            Console.ReadLine();
                                            break;

                                        case "2":
                                            Console.WriteLine($"\nNasral jsi ho.");
                                            Console.ReadLine();
                                            Console.WriteLine($"\nPak jsi ho svým ohnivým mečem rozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                                            Console.WriteLine(Texts.freyFire);
                                            Frey.setDead();
                                            menu.Remove("3 - Utkáš se s Freyem");
                                            Console.ReadLine();
                                            break;
                                        default:
                                            continue;
                                    }
                                    break;
                                }
                            }

                            else if (!Jih.active && !Sever.active && !Stred.active && !Frey.alive)
                            {
                                Console.WriteLine(Texts.end1);
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine(Texts.end2);
                                Console.WriteLine(Texts.endPic);
                                Console.ReadLine();
                                go = false;
                                break;
                            }

                            else
                            {
                                Console.WriteLine("\nZadej správné číslo.\n");
                                continue;
                            }

                            break;

                        default:
                            Console.WriteLine("\nZadej správné číslo.\n");
                            continue;
                                                    
                    }
                    break;
                }
            }
        }

    }
}
