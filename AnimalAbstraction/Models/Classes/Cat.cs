﻿using AnimalAbstraction.Models.SuperClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnimalAbstraction.Models.Classes
{
    internal class Cat : Mammal
    {
        public Cat() : base(true, 1, 2)
        {
            
        }
    }
}