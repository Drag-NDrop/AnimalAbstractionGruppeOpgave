using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.SuperClasses
{
    internal class Animal : LifeForm
    {
        protected private int _age;
        public Animal(byte gender, int age) : base(gender)
        {
            this.Gender = gender;
        }
    }
}
