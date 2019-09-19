using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Bojiste
    {
        public string CastBojiste { get; }
        public bool Active { get; private set; }
        public Priroda Priroda { get; }
        public Armada Spojenec { get; }
        public Armada Nepritel { get; }

        public Bojiste (string cast, Priroda priroda1, Armada spojenec1, Armada nepritel1)
        {
            CastBojiste = cast;
            Active = true;
            Priroda = priroda1;
            Spojenec = spojenec1;
            Nepritel = nepritel1;
        }

        // když už bude lokace projitá (splněný úkol), přehodí se to na false, 
        // aby se ve switchi objevila hláška, že už je lokace projitá.
        public void SetActiveFalse() => Active = false;

        public static void ChangeLocation(Bojiste Boj, Hero hero)
        {
            if (Boj.Active)
            {
                hero.SetLocation(Boj);
                Console.WriteLine($"\nPřesunul ses do lokace {hero.Location}.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Tam už jsi vše splnil, nemáš důvod se tam vracet.");
                Console.ReadLine();
            }
        }

        public override string ToString() => CastBojiste;
    }
}
