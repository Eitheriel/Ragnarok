using System;

namespace Ragnarok
{
    class Program
    {

        static void Main(string[] args)
        {
            Hero Surtr = new Hero("Surtr");

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

            Surtr.CoMasPoKapsach.Add(new Veci("Čtyři penny z výletu do Londýna","money"));
            Surtr.CoMasPoKapsach.Add(new Veci("Dávno prošlá krabička kondomů","kondomy"));
            Surtr.CoMasPoKapsach.Add(new Veci("Svačina z domova","jidlo"));
            Surtr.CoMasPoKapsach.Add(new Veci("Žvýkačky Winterfresh","zvejky"));

            while (true) {
                Surtr.CoMasPoKapsach.ForEach(n => Console.WriteLine(n));
                Console.WriteLine(Surtr);
                Console.ReadLine();
            }
        }
    }
}
