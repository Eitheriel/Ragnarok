using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok
{
    public class Armada
    {
        public string jmenoArmady { get; }
        public string heslo { get; }
        public string message { get; }
        public bool prirodaCheck { get; private set; }
        public bool inventoryCheck { get; private set; }
        public bool specialCheck { get; private set; }

        public Armada (string jmeno, string heslo="", string message="")
        {
            jmenoArmady = jmeno;
            this.heslo = heslo;
            this.message = message;

            prirodaCheck = true;
            inventoryCheck = true;
            specialCheck = true;
        }

        public void PrirodaFalse() => prirodaCheck = false;
        public void InventoryFalse() => inventoryCheck = false;
        public void SpecialFalse() => specialCheck = false;
        public override string ToString() => jmenoArmady;

    }
}
