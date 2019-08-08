using System;
using System.Collections.Generic;
using System.Text;


namespace Ragnarok
{
    class Program
    {
         
        static void Main(string[] args)
        {
            string proLedove = "\nRozdal jsi žvýkačky Winterfresh těm nejsilnějším ledovým obrům. Jejich dech začal být tak ledový, že jím dokázali zmrazit řady nepřátel na jeden nádech. S tímhle určitě tu bitvu vyhrajete!";
            string proAsgard = "\nAsgarďané nechápali, co děláš, jen několik valkýr na tebe vrhlo velice zajímavý pohled, při kterém jsi zalitoval, že tento den už nebude mít večer (a noc).";
            string proZbytek = "";

            Armada OhniviObri= new Armada("Ohniví Obři", false, "nic", proZbytek);
            Armada LedoviObri = new Armada("Ledoví obři", false, "zvejky",proLedove);
            Armada ArmadyHelu = new Armada("Armády říše Hell", false, "nic", proZbytek);
            Armada Elfove = new Armada("Elfové a trpaslíci", true, "nic", proZbytek);
            Armada Asgardane = new Armada("Asgarďané", true, "kondomy",proAsgard);
            Armada Einherjars = new Armada("Einherjars", true, "nic", proZbytek);

            //Prednastavení cílů
            Elfove.InventoryFalse();
            Asgardane.InventoryFalse();
            Asgardane.SpecialFalse();
            Einherjars.PrirodaFalse();
            Einherjars.SpecialFalse();

            Priroda Les = new Priroda("Les");
            Priroda More = new Priroda("More");
            Priroda Hory = new Priroda("Hory");

            Bojiste Jih = new Bojiste("Jih", Hory, OhniviObri, Elfove);
            Bojiste Stred = new Bojiste("Stred", Les, LedoviObri, Einherjars);
            Bojiste Sever = new Bojiste("Sever", More, ArmadyHelu, Asgardane);
            Bojiste[] seznamBojist = { Jih, Stred, Sever };

            Hero Surtr = new Hero("Surtr", Jih);
            Hero Frey = new Hero("Frey", Jih);

            Surtr.CoMasPoKapsach.Add(new Veci("Čtyři penny z výletu do Londýna","money"));
            Surtr.CoMasPoKapsach.Add(new Veci("Dávno prošlá krabička kondomů","kondomy"));
            Surtr.CoMasPoKapsach.Add(new Veci("Svačina z domova","jidlo"));
            Surtr.CoMasPoKapsach.Add(new Veci("Žvýkačky Winterfresh","zvejky"));
            Veci mec = new Veci("Surtalogi", "Freyova hlava");

            Console.WriteLine($"Jmenuješ se {Surtr} a přišel jsi z {Surtr.Location}u, abys v poslední bitvě spálil svět.");
            Console.ReadLine();
            bool go = true;

            while (go) {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Co uděláš?\n" +
                        "\n1 - Utkáš se s Freyem" +
                        "\n2 - Půjdeš do boje!" +
                        "\n3 - Půjdeš do jiné části bojiště" +
                        "\n4 - Podíváš se do inventáře" +
                        "\n5 - Zapálíš celý svět\n");
                    string rozhodnuti = Console.ReadLine();

                    switch (rozhodnuti)
                    {
                        case "1":
                            if (Frey.alive)
                            {
                                Console.Clear();
                                Console.WriteLine($"\nPo úvodu bitvy se postavíš jednomu z hlavních bohů - {Frey}ovi. Víš, že\n" +
                                    $"u sebe nemá zbraň - kouzelný meč, kterého se vzdal kvůli své lásce.\n...");
                                Console.ReadLine();
                                Console.WriteLine("\nMáš dvě možnosti:\n\n" +
                                    $"1 - Zabiješ ho\n2 - Pustíš mu písničku Dirty Harry od Gorillaz \n https://www.youtube.com/watch?v=cLnkQAeMbIM \n");
                                while (true)
                                {
                                    string tezkeRozhodnuti = Console.ReadLine();
                                    switch (tezkeRozhodnuti)
                                    {
                                        case "1":
                                            Console.WriteLine($"\nZaútočil jsi na {Frey}e a s obří silou jsi ho svým ohnivým mečem {mec}m \nrozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                                            Frey.setDead();
                                            break;

                                        case "2":
                                            Console.WriteLine($"\nNasral jsi ho.\n...");
                                            Console.ReadLine();
                                            Console.WriteLine($"\nPak jsi ho svým ohnivým mečem rozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                                            Frey.setDead();
                                            //Console.ReadLine();
                                            break;
                                        default:
                                            Console.WriteLine("\nJedna nebo dva. Jedna... nebo... dva.");
                                            continue;
                                    }
                                    break;
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine($"\n{Frey}e už jsi zabil.");
                                Console.ReadLine();
                            }
                            break;

                        case "2":
                            Console.Clear();
                            if (Surtr.Location.active)
                            {
                                Console.WriteLine($"\n{Surtr.Location} je plný bojů! Tvou část armády " +
                                        $"zde tvoří {Surtr.Location.spojenec}, \nnepřítelem jsou ti {Surtr.Location.nepritel}. " +
                                        $"Co se krajiny týče, vidíš zde {Surtr.Location.priroda}.\n...");
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
                                                Console.WriteLine("\nVyrazil jsi do útoku spolu se spojenci a oháněje se svým ohnivým mečem \n" +
                                                    "zabil jsi všechny nepřátele, až jsi zůstal na bojišti docela sám. Všichni spojenci padli v boji.\n...");
                                                Console.ReadLine();
                                                Surtr.Location.setActiveFalse();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nNepřátelé se na tebe sesypali jak vosy. Takticky jsi ustoupil.\n...");
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
                                                                        Console.WriteLine("\nNic zvláštního se nestalo.\n...");
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
                                                                        Console.WriteLine("\nNic zvláštního se nestalo.\n...");
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
                                                                        Console.WriteLine("\nNic zvláštního se nestalo.\n...");
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
                                                                            Console.WriteLine("\nNic zvláštního se nestalo.\n...");
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
                                                                    Console.WriteLine("\nDíváš se kolem sebe a vidíš za sebou majestátní pohoří. Zprava se k tobě \n" +
                                                                        "blíží armáda trpaslíků, těch horských červů, vedená samotným trpasličím králem. Náhle dostaneš spásný nápad! \n" +
                                                                        "'Když nemůže Mohamed k hoře, musí hora k Mohamedovi', jak vždycky říkával tvůj \n" +
                                                                        "turecký spolubydlící na koleji. Elegantně přiskočíš k blízké hoře, urveš její vrchol, \n" +
                                                                        "celý ho mrštíš na trpasličího krále a řekneš: 'Chytej!'\n...");
                                                                    Console.ReadLine();
                                                                    Console.WriteLine("\nNechytil.\n...");
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
                                                                Console.WriteLine("\n Prohlížíš si místní lesy. Jsou krásně husté, místy smíšené, ale většinou \n" +
                                                                    "jehličnaté. Na kraji lesa zurčí malý pramínek, který se rozšiřuje v úzkou bystřinu. Jistě je \n" +
                                                                    "zde hojnost divoké zvěře, ptactva i lesních plodů.\n...");
                                                                Console.ReadLine();
                                                                Console.WriteLine("\nNo ale to je ti teď stejně k hovnu.");
                                                            }

                                                            else
                                                            {
                                                                if (Surtr.Location.nepritel.prirodaCheck)
                                                                {
                                                                    Console.WriteLine("\nJéé, moře! U moře už jsi nebyl ani nepamatuješ! Sundal sis kaťata a hupsnul do vln!\n...");
                                                                    Console.ReadLine();
                                                                    Console.WriteLine("\nVznešení Asgarďané, kteří byli spolu s Valkýrami v prvních řadách nepřátelské armády, \n" +
                                                                        "měli tu smůlu, že spatřili tvé privátní partie dřív, než je zalilo milosrdné moře. Maje ten pohled \n" +
                                                                        "před očima, nebyli schopni nadále bojovat a jen stěží se bránili dorážení tvé armády.");
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
                                                                    Console.WriteLine("\nTvoji vojáci jsou nervózní a vidíš, že mají pochyby o vítězství. " +
                                                                        "Proto se rozhodneš předvést jim překvapení, které sis plánoval na vánoční besídku. " +
                                                                        "Pozveš si k sobě generály tvých vojsk, se kterými jsi tajně trénoval a vytvořil " +
                                                                        "folkový kvartet. A zatímco nepřítel se kvapem blíží, předstoupíte před své muže a " +
                                                                        "začnete z plna hrdla zpívat bojovou píseň, abyste jim dodali odvahy. \n\nHlavní elf, překvapen disharmonickým zvukem, " +
                                                                        "který z lesa neznal, se zarazil. To ti dává čas vymyslet řádný protiúder.\n...");
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

                        case "3":
                            Console.Clear();
                            while (true)
                            {
                                Console.WriteLine($"\nTvým bojištěm je nyní {Surtr.Location}. Můžeš si vybrat:\n\nBuď zůstaneš tam, kde jsi (zmáčkni Enter)," +
                                    "\nnebo můžeš jít na:\n");

                                foreach (Bojiste b in seznamBojist)
                                {
                                    if (b != Surtr.Location)
                                        Console.WriteLine(b);
                                }
                                Console.WriteLine("\n");
                                    string zmenaMista = Console.ReadLine();

                                switch (zmenaMista)
                                {
                                    case "Jih":
                                    case "jih":
                                        if (Jih.active) Surtr.setLocation(Jih);
                                        else Console.WriteLine("Na jihu už jsi vše splnil, nemáš důvod se tam vracet.");
                                        break;

                                    case "Stred":
                                    case "stred":
                                        if (Stred.active) Surtr.setLocation(Stred);
                                        else Console.WriteLine("Ve středu bojiště už jsi vše splnil, nemáš důvod se tam vracet.");
                                        break;


                                    case "Sever":
                                    case "sever":
                                        if (Sever.active) Surtr.setLocation(Sever);
                                        else Console.WriteLine("\nNa severu už jsi vše splnil, nemáš důvod se tam vracet.");
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

                        case "4":
                            Console.Clear();
                            Console.WriteLine("V inventáři máš:\n");
                            Surtr.CoMasPoKapsach.ForEach(n => Console.WriteLine($"- {n}"));
                            Console.WriteLine("\n");
                            Console.ReadLine();
                            break;

                        case "5":
                            Console.Clear();
                            if (!Jih.active && !Sever.active && !Stred.active && !Frey.alive)
                            {
                                Console.WriteLine("\nKonečně nadešla poslední chvíle světa. Zůstal jsi na bojišti úplně sám. \n" +
                                    "Všude kolem leží mrtví bohové, lidé, elfové a obři. Frey už nemůže být bohem plodnosti, \n" +
                                    "ale maximálně tak bohem popela.\n\n Zabodl jsi svůj ohnivý meč do země a zapálil jsi svět." +
                                    "Pak ses proměnil v obrovského \nohnivého orla a zapálil i nebesa.\n...");
                                Console.ReadLine();
                                Console.WriteLine("\nVšechno hoří.Je konec.");
                                go = false;
                                break;
                            }
                            else Console.WriteLine("\nJeště jsi nevykonal všechny úkoly, ještě není svět připraven na záhubu.\n...");
                                Console.ReadLine();
                                continue;

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
