using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Hero
    {
        public string Name { get; }
        public Bojiste Location { get; private set; }
        public List<Veci> CoMasPoKapsach { get; set; }

        public Hero (string vlozJmeno, Bojiste misto)
        {
            Location = misto;
            Name = vlozJmeno;
            CoMasPoKapsach = new List<Veci>();
        }

        public void PodivejSeDoKapes()
        {
            //CoMasPoKapsach.ForEach(n => Console.WriteLine(n));
            
            for (int i=1; i < CoMasPoKapsach.Count; i++)
            {
                Console.WriteLine($"{i}: {CoMasPoKapsach[i]}");
            }
        }
        public void setLocation(Bojiste misto)
        {
            Location = misto;
        }

        public override string ToString()
        {
            return $"Já jsem {Name}!";
        }
    }
}
