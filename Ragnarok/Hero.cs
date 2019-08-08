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
        public List<Veci> CoMasPoKapsach { get; set; }

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

        public override string ToString() => Name;
    }
}
