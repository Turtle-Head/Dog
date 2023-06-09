﻿using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOG
{
    internal class Cat : Animal
    {
       
        public Cat(string Name, int Age, string Breed, string Species, string Mood) : base(Name, Age, Breed, Species, Mood)
        { }

        internal override string Sleeping(Animal animal)
        {
            return $"{Name} the {_Species} is sleeping... \n";
        }
    }
}
