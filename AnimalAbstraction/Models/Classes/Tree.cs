using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalAbstraction.Models.SuperClasses;

namespace AnimalAbstraction.Models.Classes
{
    internal class Tree : Plant 
    {
        public Tree(string plantType, byte gender) : base(plantType, gender)
        {
            this.plantType = plantType;
            this.Gender = gender;
        }

        public void writeCharacteristics() {

            Console.WriteLine("Gender: " + this.GenderDescription);
            Console.WriteLine("Size: " + this._size);
            Console.WriteLine("Type: " + this.plantType) ;
        }
    }
}
