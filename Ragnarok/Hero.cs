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
        public Dictionary<int, Bojiste> CeleBojiste { get; private set; }

        public Hero (string vlozJmeno, Bojiste misto)
        {
            Location = misto;
            Name = vlozJmeno;
            alive = true;
            CeleBojiste = new Dictionary<int, Bojiste>();
        }

        public void setDead() => alive = false;

        public void setLocation(Bojiste misto) => Location = misto;

        public void ZobrazBojiste(Bojiste[] seznam)
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
