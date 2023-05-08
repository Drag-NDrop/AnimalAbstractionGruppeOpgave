using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.SuperClasses
{
    internal class Mammal : Animal
    {

        protected private bool hasMilk = true;
        public Mammal(bool hasMilk, byte gender, int age) : base(gender, age)
        {
            this.hasMilk = hasMilk;
        }
    }
}