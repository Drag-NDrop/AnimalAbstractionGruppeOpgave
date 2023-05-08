using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.Classes
{
    internal class Snake : Reptile
    {
        public Snake(bool coldBlooded, byte gender, int age) : base(coldBlooded,gender,age)
        {
            
        }

        public void DislocateJaw()
        {

        }
    }
}
