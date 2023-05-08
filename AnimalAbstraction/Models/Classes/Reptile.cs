using AnimalAbstraction.Models.SuperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.Classes
{
    internal abstract class Reptile : Animal
    {
        public bool coldBlooded { get; set; }

        public Reptile() : base()
        {
            
        }
    }
}
