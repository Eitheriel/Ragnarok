using System;

namespace Ragnarok
{
    class Program
    {

        static void Main(string[] args)
        {
            Armada OhniviObri= new Armada("Ohniví Obři", false);
            Armada LedoviObri = new Armada("Ledoví obři", false);
            Armada ArmadyHelu = new Armada("Armády říše Hell", false);
            Armada Elfove = new Armada("Elfové", true);
            Armada Asgardane = new Armada("Asgarďané", true);
            Armada Einherjars = new Armada("Einherjars", true);

            Priroda Les = new Priroda("Les");
            Priroda More = new Priroda("More");
            Priroda Hory = new Priroda("Hory");

            Bojiste Jih = new Bojiste("Jih", Hory, OhniviObri, Elfove);
            Bojiste Stred = new Bojiste("Stred", Les, LedoviObri, Einherjars);
            Bojiste Sever = new Bojiste("Sever", More, ArmadyHelu, Asgardane);

            Hero Surtr = new Hero("Surtr", Jih);

            Surtr.CoMasPoKapsach.Add(new Veci("Čtyři penny z výletu do Londýna","money"));
            Surtr.CoMasPoKapsach.Add(new Veci("Dávno prošlá krabička kondomů","kondomy"));
            Surtr.CoMasPoKapsach.Add(new Veci("Svačina z domova","jidlo"));
            Surtr.CoMasPoKapsach.Add(new Veci("Žvýkačky Winterfresh","zvejky"));

            while (true) {
                Surtr.CoMasPoKapsach.ForEach(n => Console.WriteLine(n));
                Console.WriteLine(Surtr);
                Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("Co uděláš?\n" +
                        "\n1 - Porozhlédneš se kolem" +
                        "\n2 - Půjdeš do jiné části bojiště" +
                        "\n3 - podíváš se do inventáře");
                    string rozhodnuti = Console.ReadLine();

                    switch (rozhodnuti)
                    {
                        case "1":

                            break;

                        case "2":
                            while (true)
                            {
                                Console.WriteLine("Můžeš si vybrat:" +
                                    "\n1 - Jih" +
                                    "\n2 - Střed" +
                                    "\n3 - Sever");
                                string zmenaMista = Console.ReadLine();

                                switch (zmenaMista)
                                {
                                    case "1":
                                        break;

                                    case "2":
                                        break;

                                    case "3":
                                        break;

                                    default:
                                        Console.WriteLine("Zadej správné číslo.");
                                        continue;
                                }
                                break;

                            }
                            break;

                        case "3":
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
