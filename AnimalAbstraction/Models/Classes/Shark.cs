using AnimalAbstraction.Models.SuperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.Classes
{
    internal class Shark : Fish
    {
        public Shark(byte gender, int age) : base(gender, age)
        {
        }
    }
}
