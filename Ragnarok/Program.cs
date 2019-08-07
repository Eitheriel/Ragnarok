using System;
using System.Collections.Generic;
using System.Text;


namespace Ragnarok
{
    class Program
    {
         
        static void Main(string[] args)
        {
            Armada OhniviObri= new Armada("Ohniví Obři", false, "nic");
            Armada LedoviObri = new Armada("Ledoví obři", false, "zvejky");
            Armada ArmadyHelu = new Armada("Armády říše Hell", false, "nic");
            Armada Elfove = new Armada("Elfové", true, "nic");
            Armada Asgardane = new Armada("Asgarďané", true, "kondomy");
            Armada Einherjars = new Armada("Einherjars", true, "nic");

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

            Console.WriteLine($"Jmenuješ se {Surtr} a přišel jsi z {Surtr.Location}u, abys v poslední bitvě zničil svět.");
            Console.ReadLine();

            while (true) {

                while (true)
                {
                    Console.WriteLine("Co uděláš?\n" +
                        "\n1 - Utkáš se s Freyem" +
                        "\n2 - Porozhlédneš se kolem" +
                        "\n3 - Půjdeš do jiné části bojiště" +
                        "\n4 - podíváš se do inventáře\n");
                    string rozhodnuti = Console.ReadLine();

                    switch (rozhodnuti)
                    {
                        case "1":
                            if (Frey.alive)
                            {
                                Console.WriteLine($"Po úvodu bitvy se postavíš jednomu z hlavních bohů - {Frey}ovi. Víš, že\n" +
                                    $"u sebe nemá zbraň - kouzelný meč, kterého se vzdal kvůli své lásce.\n\nMáš dvě možnosti:\n\n" +
                                    $"1 - Zabiješ ho\n2 - Pustíš mu písničku Dirty Harry od Gorillaz \n https://www.youtube.com/watch?v=cLnkQAeMbIM \n");
                                while (true)
                                {
                                    string tezkeRozhodnuti = Console.ReadLine();
                                    switch (tezkeRozhodnuti)
                                    {
                                        case "1":
                                            Console.WriteLine($"Zaútočil jsi na {Frey}e a s obří silou jsi ho svým ohnivým mečem rozsekl " +
                                                $"ve dví, \naž z něj zbyl jen černý škvarek.");
                                            Frey.setDead();
                                            break;

                                        case "2":
                                            Console.WriteLine($"\nNasral jsi ho.");
                                            Console.ReadLine();
                                            Console.WriteLine($"Pak jsi ho svým ohnivým mečem rozsekl " +
                                                $"ve dví, až z něj zbyl jen černý škvarek.");
                                            Frey.setDead();
                                            //Console.ReadLine();
                                            break;
                                        default:
                                            Console.WriteLine("Jedna nebo dva. Jedna... nebo... dva.");
                                            continue;
                                    }
                                    break;
                                }
                            }
                            else
                                Console.WriteLine($"\n{Frey}e už jsi zabil.");
                                Console.ReadLine();
                            break;

                        case "2":
                            if (Surtr.Location.active)
                            {
                                Console.WriteLine($"\n{Surtr.Location} je plný bojů! Tvou část armády " +
                                        $"zde tvoří {Surtr.Location.spojenec}, \nnepřítelem jsou ti {Surtr.Location.nepritel}. " +
                                        $"Co se krajiny týče, vidíš zde {Surtr.Location.priroda}.\n\nCo uděláš?\n\n" +
                                        $"1 - Zaútočíš na tu trapnou armádu, kterou tvoří {Surtr.Location.nepritel}, přímo!\n" +
                                        $"2 - Vymyslíš něco lepšího\n" +
                                        $"3 - Odejdeš.");
                                while (true)
                                {

                                    string coTed = Console.ReadLine();
                                    switch (coTed)
                                    {
                                        case "1":
                                            Console.WriteLine("\nNepřátelé se na tebe sesypali jak mouchy. Takticky jsi ustoupil..");
                                            Console.ReadLine();
                                            continue;


                                        default:
                                            break;
                                    }
                                }
                            }
                            else
                                Console.WriteLine("Už jsi tu úkol splnil a měl bys jít bojovat jinam.");

                            break;

                        case "3":
                            while (true)
                            {
                                Console.WriteLine($"\nTvým bojištěm je nyní {Surtr.Location}. Můžeš si vybrat:\n\nBuď zůstaneš tam, kde jsi (zmáčkni Enter)," +
                                    "\nnebo můžeš jít na:");
                                for (int i = 0; i < seznamBojist.Length;i++)
                                {
                                    if (seznamBojist[i] != Surtr.Location)
                                        Console.WriteLine(seznamBojist[i]);
                                }
                                Console.WriteLine("\n");
                                    string zmenaMista = Console.ReadLine();

                                switch (zmenaMista)
                                {
                                    case "Jih":
                                    case "jih":
                                        if (Jih.active)
                                            Surtr.setLocation(Jih);
                                        else
                                            Console.WriteLine("Na jihu už jsi vše splnil, nemáš důvod se tam vracet.");
                                        break;

                                    case "Stred":
                                    case "stred":
                                        Surtr.setLocation(Stred);
                                        break;

                                    case "Sever":
                                    case "sever":
                                        Surtr.setLocation(Sever);
                                        break;

                                    case "":
                                        break;

                                    default:
                                        Console.WriteLine("Zadej správné umístění.");
                                        continue;
                                }
                                break;

                            }
                            break;

                        case "4":
                            Surtr.CoMasPoKapsach.ForEach(n => Console.WriteLine(n));
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
