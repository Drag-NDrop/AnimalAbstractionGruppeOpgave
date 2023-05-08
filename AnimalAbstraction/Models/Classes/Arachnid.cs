using AnimalAbstraction.Models.SuperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.Classes
{
    internal abstract class Arachnid : Animal
    {
        public Type Is { get; set; }

        public Arachnid(byte gender, int age) : base(gender, age)
        {
            Is = typeof(Arachnid);
        }

        public virtual void Hunt()
        {

        }
    }
}
