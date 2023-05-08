using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.Classes
{
    internal class Spider : Arachnid
    {
        public bool IsSpindler { get; set; }
        public Spider(byte gender, int age) : base(gender, age)
        {
        
        }

        public override void Hunt()
        {
            base.Hunt();
        }
    }
}
