using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    class Inventar
    {
        public Dictionary<int, Veci> Kapsy { get; private set; }

        public Inventar()
        {
            Kapsy = new Dictionary<int, Veci>();
        }

        public void PridejDoKapes(params Veci[] vecicky)
        {
            int i = 0;
            foreach (Veci vec in vecicky)
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
        public bool Pouzij(int index, Hero Surtr)
        {
            if (Kapsy[index].ucelVeci == Surtr.Location.Nepritel.heslo)
            {
                Console.WriteLine(Surtr.Location.Nepritel.message);
                Surtr.Location.Nepritel.InventoryFalse();
                Kapsy.Remove(index);
                Console.ReadLine();
                Console.Clear();
                return false;
            }
            else if (Kapsy[index].ucelVeci == Surtr.Location.Spojenec.heslo)
            {
                Console.WriteLine(Surtr.Location.Spojenec.message);
                Surtr.Location.Nepritel.InventoryFalse();
                Kapsy.Remove(index);
                Console.ReadLine();
                Console.Clear();
                return false;
            }
            else
            {
                Console.WriteLine("\nNic zvláštního se nestalo.");
                Console.ReadLine();
                Console.Clear();
                return true;
            }
        }
    }
}
