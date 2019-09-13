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
        public Dictionary<int,Veci> Kapsy { get; private set; }
        public Dictionary<int, Bojiste> CeleBojiste { get; private set; }

        public Hero (string vlozJmeno, Bojiste misto)
        {
            Location = misto;
            Name = vlozJmeno;
            Kapsy = new Dictionary<int, Veci>();
            alive = true;
            CeleBojiste = new Dictionary<int, Bojiste>();
        }
        public void PridejDoKapes(params Veci[] vecicky)
        {
            int i = 0;
            foreach(Veci vec in vecicky)
            {
                Kapsy.Add(i + 1, vec);
                i++;
            }
        }
        public void PodivejSeDoKapes()
        {
            foreach (KeyValuePair<int, Veci> kvp in Kapsy)
            {
                Console.WriteLine($"{ kvp.Key} - {kvp.Value}");
            }
        }

        public void setDead() => alive = false;

        public void setLocation(Bojiste misto) => Location = misto;

        public void Pouzij(int index, Hero Surtr)
        {
            if (Surtr.Kapsy[index].ucelVeci == Surtr.Location.nepritel.heslo)
            {
                Console.WriteLine(Surtr.Location.nepritel.message);
                Surtr.Location.nepritel.InventoryFalse();
                Surtr.Kapsy.Remove(index);
                Console.ReadLine();
                Console.Clear();
            }
            else if (Surtr.Kapsy[index].ucelVeci == Surtr.Location.spojenec.heslo)
            {
                Console.WriteLine(Surtr.Location.spojenec.message);
                Surtr.Location.nepritel.InventoryFalse();
                Surtr.Kapsy.Remove(index);
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
        public void PodivejSePoBojisti(Bojiste[] seznam)
        {
            int i =1;
            CeleBojiste.Clear();
            foreach (Bojiste a in seznam)
            {
                if (a != Location)
                {
                    CeleBojiste.Add(i, a);
                    Console.WriteLine($"{i} - {a}");
                    i++;
                }
            }
        }
        public override string ToString() => Name;
    }
}
