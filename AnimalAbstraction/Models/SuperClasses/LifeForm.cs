using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.SuperClasses
{
    public class LifeForm
    {
        protected private string _gender;
        public LifeForm(byte gender)
        {
            switch (gender)
            {
                case 0: { this._gender = "Female"; }
                    break;
                case 1: { this._gender = "Male";  } 
                    break;
                case 2: { this._gender = "Non-Binary"; }
                    break;
                default:
                    break;
            }
            
        }
        
        public string Gender
        {
            get
            {
                return Gender;
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
