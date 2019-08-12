using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Hero
    {
        public string Name { get; }
        public bool alive { get; private set; }
        public Bojiste Location { get; private set; }
        public List<Veci> CoMasPoKapsach { get; private set; }

        public Hero (string vlozJmeno, Bojiste misto)
        {
            Location = misto;
            Name = vlozJmeno;
            CoMasPoKapsach = new List<Veci>();
            alive = true;
        }

        public void PodivejSeDoKapes()
        {
            //CoMasPoKapsach.ForEach(n => Console.WriteLine(n));

            for (int i = 1; i < CoMasPoKapsach.Count; i++)
            {
                Console.WriteLine($"{i}: {CoMasPoKapsach[i]}");
            }
        }

        public void VecJePryc(Veci vec) => _ = CoMasPoKapsach.Remove(vec);

        public void setDead() => alive = false;

        public void setLocation(Bojiste misto) => Location = misto;

        public void Pouzij(int index, Hero Surtr)
        {
            if (Surtr.CoMasPoKapsach[index].ucelVeci == Surtr.Location.nepritel.heslo)
            {
                Console.WriteLine(Surtr.Location.nepritel.message);
                Surtr.Location.nepritel.InventoryFalse();
                Console.ReadLine();
                Console.Clear();
            }
            else if (Surtr.CoMasPoKapsach[index].ucelVeci == Surtr.Location.spojenec.heslo)
            {
                Console.WriteLine(Surtr.Location.spojenec.message);
                Surtr.Location.nepritel.InventoryFalse();
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNic zvláštního se nestalo.");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public override string ToString() => Name;
    }
}
