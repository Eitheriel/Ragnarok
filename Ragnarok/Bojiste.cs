using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Bojiste
    {
        public string castBojiste { get; }
        public bool active { get; private set; }
        public Priroda priroda { get; }
        public Armada spojenec { get; }
        public Armada nepritel { get; }

        public Bojiste (string cast, Priroda priroda1, Armada spojenec1, Armada nepritel1)
        {
            castBojiste = cast;
            active = true;
            priroda = priroda1;
            spojenec = spojenec1;
            nepritel = nepritel1;
        }

        // když už bude lokace projitá (splněný úkol), přehodí se to na false, 
        // aby se ve switchi objevila hláška, že už je lokace projitá.
        public void setActiveFalse() => active = false;

        public static void ChangeLocation(Bojiste Boj, Hero hero)
        {
            if (Boj.active)
            {
                hero.setLocation(Boj);
                Console.WriteLine($"\nPřesunul ses do lokace {hero.Location}.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Na jihu už jsi vše splnil, nemáš důvod se tam vracet.");
                Console.ReadLine();
            }
        }

        public override string ToString() => castBojiste;
    }
}
