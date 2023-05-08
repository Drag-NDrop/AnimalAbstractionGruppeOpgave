using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.SuperClasses
{
    public class LifeForm
    {
       
        public string? GenderDescription { get; set; }
        public LifeForm(byte gbyte)
        {
            this.Gender = gbyte;
        }
       
        protected private int _size;

        public byte Gender
        {

            set
            {
                switch (value)
                {
                    case 0:
                        { GenderDescription = "Female"; }
                        break;
                    case 1:
                        { GenderDescription = "Male"; }
                        break;
                    case 2:
                        { GenderDescription = "Non-Binary"; }
                        break;
                    default:
                        break;
                }

            } 
        }

        public virtual void Seed() {
            // 
        }
        public virtual void Grow() {
            this._size++;
        }
 
    }

    
}
