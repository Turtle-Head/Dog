using DocumentFormat.OpenXml.Office.CoverPageProps;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOG
{
    internal class Dog : Animal
    {
       
        public Dog(string Name, int Age, string Breed, string Species, string Mood) : base(Name, Age, Breed, Species, Mood)
        {
            

        }

        public object Species { get; internal set; }

        internal override string Sleeping(Animal animal)
        {
            return $"{Name} the {_Species} is sleeping... \n";
        }


    }
    }







