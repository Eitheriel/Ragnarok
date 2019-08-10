using System;
using System.Collections.Generic;
using System.Text;


namespace Ragnarok
{
    class Program
    {
         
        static void Main(string[] args)
        {
            string proLedove = "\nRozdal jsi žvýkačky Winterfresh těm nejsilnějším ledovým obrům. Jejich dech začal být tak ledový, že jím dokázali zmrazit řady nepřátel na jeden nádech. S tímhle určitě bitvu vyhrajete!";
            string proAsgard = "\nAsgarďané nechápali, co děláš, jen několik valkýr na tebe vrhlo velice zajímavý pohled, při kterém jsi zalitoval, že tento den už nebude mít večer (a noc).";
            string proZbytek = "";

            Armada OhniviObri= new Armada("Ohniví Obři", "nic", proZbytek);
            Armada LedoviObri = new Armada("Ledoví obři", "zvejky",proLedove);
            Armada ArmadyHelu = new Armada("Armády říše Hell", "nic", proZbytek);
            Armada Elfove = new Armada("Elfové a trpaslíci", "nic", proZbytek);
            Armada Asgardane = new Armada("Asgarďané", "kondomy",proAsgard);
            Armada Einherjars = new Armada("Einherjars", "nic", proZbytek);

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

            Console.WriteLine($" ______                                  _    " +
                $"\n | ___ \\                                | |   " +
                $"\n | |_/ /__ _  __ _ _ __   __ _ _ __ ___ | | __" +
                $"\n |    // _` |/ _` | '_ \\ / _` | '__/ _ \\| |/ /" +
                $"\n | |\\ \\ (_| | (_| | | | | (_| | | | (_) |   < " +
                $"\n \\_| \\_\\__,_|\\__, |_| |_|\\__,_|_|  \\___/|_|\\_\\ " +
                $"\n             __/ |                           " +
                $"\n            |___/                            \n");

            Console.WriteLine("Intro:\n------\n\nPo třech letech nepřetržité zimy, označované jako Fimbulwinter (Velká zima), se v září náhle změnilo počasí a začal vát jižní vítr. Obrovské masy sněhu a ledu, které se nastřádaly za ty roky, roztály a způsobily katastrofální povodně po celém světě.\n\nA pak nadešel okamžik zvěstující příchod Ragnaroku: Vlk, který od počátku věků pronásledoval slunce po obloze, ho dohonil a spolknul. Nastala temnota a hrozné zemětřesení, kdy pukala země a také všechna pouta. A tak se osvobodil monstrózní vlk Fenrir, syn Lokiho, ze svých pout. Osvobodil se také sám Loki, uvězněný za to, že zavinil smrt Baldra.");
            Console.ReadLine();
            Console.WriteLine("Vše se dalo do pohybu. Obrovský Fenrir s chřtánem otevřeným od země až po vrch nebeské klenby se hnal proti Ásgardu a proti bohům. Po jeho boku se plazil Jormungandr, gigantický mořský had dštící smrtící jed. V Jotunheimenu se houfovali ledoví obři, odvěcí nepřátelé bohů a taktéž vyrazili na pochod. Po moři k Ásgardu plula loď Naglfar - hrůzostrašný koráb zhotovený z nehtů nebožtíků - převážející nemrtvou armádu z říše mrtvých, které vládla Hel. A na jihu, v zemi Muspelheim, sedláš oře se svým vojskem i ty, Surtr, ohnivý obr, který od počátku světa stojí na hranicích své ohnivé říše a čeká, až přijde Ragnarok. Všichni vyrážíte proti bohům sídlícím v Ásgardu\n\nTam je poplach. Heimdall troubí ze své strážnice na obrovský roh a burcuje bohy k obraně. Vládce bohů Odin sedlá svého osminohého koně Sleipnira a připravuje si své kouzelné kopí Gungnir, které nikdy nemine cíl. Mocný Thor si navléká rukavice síly a pás síly a naposledy si čisté své kouzelné kladivo Mjölnir. Také dalčí bohové se chystají do boje - Týr, bůh války a spravedlnosti, Heimdall - strážce Ásgardu a Bifröstu, Frey - bůh plodnosti a další. Do boje se šikují armády severských hrdinů Einherjarů, nejlepších válečníků, kteří padli v bitvě a měli tu čest vstoupit do Valhally a tam se připravovat na poslední bitvu. Dalšími spojenci bohů jsou kouzelné bytosti elfové, obývající Alfheim a trpaslíci, obývající Swartalfheim. Ti všichni budou čelit v následujících hodinách svému osudu.\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("A hle! Již bitva započala!\n\nOdin v zářícím brnění jedoucí v čele armád bohů vyrazil na planině Vigríd před Ásgardem proti strašnému Fenrirovi. Hodil mu do chřtánu kopí, avšak ten jen spolknul a ihned poté i samotného bezbranného Odina. Avšak Odin byl pomstěn svým synem Vídarem Mlčenlivým, který Fenrirovi těžkou botou přišlápl dolní čelist k zemi a horní mu roztrhl, až vlk pošel.\n\nHned vedle Odina bojoval Thor s hadem Jormungandrem. Thor hodil po hadovi kladivo, kterým ho zabil, avšak umírající plaz naposled vypustil jedovatý dým, jímž Thora otrávil - ušel devět kroků a padl mrtev.\n\nTyr se pobil s další hrozivou stvůrou: psem Garmem, který původně strážil vstup do říše Hel. Navzájem se zabili.\n\nHeimdall se střetl s Lokim a také oni si vzájemně přivodili smrt.");
            Console.ReadLine();
            Console.WriteLine("Ty, Surtr, máš před sebou veliký úkol. Nejdříve se utkáš v boji s bohem Freyem a pak i s armádami bohů a jejich spojenci. Osud ti určil, že ty jediný bitvu přežiješ. Ty jediný zvítězíš a budeš zkázou tohoto světa...");
            Console.ReadLine();
            Console.WriteLine("...a právě teď jsi dorazil na bojiště v čele svých děsivých vojů.\n");
            Console.ReadLine();

            bool go = true;


            while (go) {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(" Co uděláš?\n" +
                        " ----------\n" +
                        "\n 1 - Utkáš se s Freyem" +
                        "\n 2 - Půjdeš do boje!" +
                        "\n 3 - Půjdeš do jiné části bojiště" +
                        "\n 4 - Podíváš se do inventáře" +
                        "\n 5 - Zapálíš celý svět\n" +
                        "\nO=={::::::::::> <::::::::::}==O\n");
                    string rozhodnuti = Console.ReadLine();

                    switch (rozhodnuti)
                    {
                        case "1":
                            if (Frey.alive)
                            {
                                Console.Clear();
                                Console.WriteLine($"\nPo úvodu bitvy se postavíš jednomu z hlavních bohů - {Frey}ovi. Víš, že\n" +
                                    $"u sebe nemá zbraň - kouzelný meč, kterého se vzdal kvůli své lásce.");
                                Console.ReadLine();
                                Console.WriteLine("Máš dvě možnosti:\n\n" +
                                    $"1 - Zabiješ ho\n2 - Pustíš mu písničku Dirty Harry od Gorillaz \n https://www.youtube.com/watch?v=cLnkQAeMbIM \n");
                                while (true)
                                {
                                    string tezkeRozhodnuti = Console.ReadLine();
                                    switch (tezkeRozhodnuti)
                                    {
                                        case "1":
                                            Console.WriteLine($"\nZaútočil jsi na {Frey}e a s obří silou jsi ho svým ohnivým mečem {mec}m \nrozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek." +
                                                $"\n       ." +
                                                $"\n      .M" +
                                                $"\n     ,MM" +
                                                $"\n     MM:" +
                                                $"\n .   YMM," +
                                                $"\n M   'MMM,     ," +
                                                $"\n M.   `MMM    .M " +
                                                $"\n MM,  ,MMM   ,MM" +
                                                $"\n \"MM, MMM'  ,MM'" +
                                                $"\n ,MMM.MMMMM.MMM," +
                                                $"\n MMMMMMMMMMMMMMM" +
                                                $"\n MMMMMMMMMMMMMMM" +
                                                $"\n 'MMMMMMMMMMMMM'" +
                                                $"\n   \"\"\"\"\"\"\"\"\"\"\"");
                                            Frey.setDead();
                                            Console.ReadLine();
                                            break;

                                        case "2":
                                            Console.WriteLine($"\nNasral jsi ho.");
                                            Console.ReadLine();
                                            Console.WriteLine($"\nPak jsi ho svým ohnivým mečem rozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek." +
                                                $"\n       ." +
                                                $"\n      .M" +
                                                $"\n     ,MM" +
                                                $"\n     MM:" +
                                                $"\n .   YMM," +
                                                $"\n M   'MMM,     ," +
                                                $"\n M.   `MMM    .M " +
                                                $"\n MM,  ,MMM   ,MM" +
                                                $"\n \"MM, MMM'  ,MM'" +
                                                $"\n ,MMM.MMMMM.MMM," +
                                                $"\n MMMMMMMMMMMMMMM" +
                                                $"\n MMMMMMMMMMMMMMM" +
                                                $"\n 'MMMMMMMMMMMMM'" +
                                                $"\n   \"\"\"\"\"\"\"\"\"\"\"");
                                            Frey.setDead();
                                            Console.ReadLine();
                                            break;
                                        default:
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
                                                Console.WriteLine("\nVyrazil jsi do útoku spolu se spojenci a oháněje se svým ohnivým mečem \n" +
                                                    "zabil jsi všechny nepřátele, až jsi zůstal na bojišti docela sám. Všichni spojenci padli v boji.");
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
                                                                    Console.WriteLine("\nDíváš se kolem sebe a vidíš za sebou majestátní pohoří. Zprava se k tobě \n" +
                                                                        "blíží armáda trpaslíků, těch horských červů, vedená samotným trpasličím králem. Náhle dostaneš spásný nápad! \n" +
                                                                        "'Když nemůže Mohamed k hoře, musí hora k Mohamedovi', jak vždycky říkával tvůj \n" +
                                                                        "turecký spolubydlící na koleji. Elegantně přiskočíš k blízké hoře, urveš její vrchol, \n" +
                                                                        "celý ho mrštíš na trpasličího krále a řekneš: 'Chytej!'");
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
                                                                Console.WriteLine("\n Prohlížíš si místní lesy. Jsou krásně husté, místy smíšené, ale většinou \n" +
                                                                    "jehličnaté. Na kraji lesa zurčí malý pramínek, který se rozšiřuje v úzkou bystřinu. Jistě je \n" +
                                                                    "zde hojnost divoké zvěře, ptactva i lesních plodů.");
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
                                                                        "který z lesa neznal, se zarazil. To ti dává čas vymyslet řádný protiúder.");
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
                                    "\nnebo napiš do konzole místo, kam chceš jít:\n");

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
                                            Console.WriteLine($"\nPřesunul ses do lokace {Surtr.Location}");
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
                                Console.WriteLine("\nKonečně nadešla poslední chvíle světa. Zůstal jsi na bojišti úplně sám. " +
                                    "Všude kolem leží mrtví bohové, lidé, elfové a obři." +
                                    "\n\n Naposledy ses nadechnul a pak jsi vší silou zarazil svůj ohnivý meč \n" +
                                    "do země a uvrhl celý svět do plamenů.");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("\n                  Nastala ohnivá apokalypsa, všechno shořelo. \n                                   Je konec." +
                                    "\n           .                                                      ." +
                                    "\n         .n                   .                 .                  n." +
                                    "\n   .   .dP                  dP                   9b                 9b.   ." +
                                    "\n  4    qXb         .       dX                     Xb       .        dXp    t" +
                                    "\n dX.    9Xb      .dXb    __                         __    dXb.     dXP    .Xb" +
                                    "\n 9XXb._       _.dXXXXb dXXXXbo.                .odXXXXb dXXXXb._       _.dXXP" +
                                    "\n  9XXXXXXXXXXXXXXXXXXVXXXXXXXXOo.           .oOXXXXXXXXVXXXXXXXXXXXXXXXXXXXP" +
                                    "\n   `9XXXXXXXXXXXXXXXXXXXX'~   ~`OOO8b   d8OOO'~   ~`XXXXXXXXXXXXXXXXXXXXXP'" +
                                    "\n    `9XXXXXXXXXXXP' `9XX'          `98V8P'          `XXP' `9XXXXXXXXXXXP' " +
                                    "\n        ~~~~~~~       9X.          .db|db.          .XP       ~~~~~~~" +
                                    "\n                       )Xb.  .dbo.dP'`v'`9b.odb.  .dX(" +
                                    "\n                      ,dXXXXXXXXXXXb     dXXXXXXXXXXXb." +
                                    "\n                     dXXXXXXXXXXXP'   .   `9XXXXXXXXXXXb" +
                                    "\n                    dXXXXXXXXXXXXb   d|b   dXXXXXXXXXXXXb" +
                                    "\n                     9XXb'  `XXXXXb.dX|Xb.dXXXXX'   `dXXP" +
                                    "\n                      `'     9XXXXXX(   )XXXXXXP      `'" +
                                    "\n                              XXXX X.`v'.X XXXX" +
                                    "\n                              XP^X'`b   d'`X^XX" +
                                    "\n                              X. 9  `   '  P )X" +
                                    "\n                              `b  `       '  d' " +
                                    "\n                               `             '" +
                                    "");
                                Console.ReadLine();
                                go = false;
                                break;
                            }
                            else Console.WriteLine("\nJeště jsi nevykonal všechny úkoly, ještě není svět připraven na záhubu.");
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
