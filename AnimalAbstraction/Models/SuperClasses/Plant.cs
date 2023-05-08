using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalAbstraction.Models.SuperClasses;

namespace AnimalAbstraction.Models.Classes
{
    internal class Plant : LifeForm
    {

        protected private string plantType = "";
        public Plant(string plantType, byte gender) : base(gender)
        {
            this.plantType = plantType;
        }
    }
}
