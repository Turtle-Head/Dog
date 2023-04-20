using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOG
{
    internal abstract class Animal
    {

        //fields
        protected string _Name;
        protected int _Age;
        protected string _Breed;
        protected string _Species;
        protected string _Mood;

        public Animal(string name, int age, string breed, string species, string mood)
        {
            this._Name = name;
            this._Breed = breed;
            this._Age = age;
            this._Species = species;
            this._Mood = mood;
        }
        public string Name { get { return _Name; } set { _Name = value; } }

        public string Species { get { return _Species; } set { _Species = value; } }
        public int Age
        {
            get { return _Age; }
            set
            {
                if (value < 0 || value > 25)
                {
                    _Age = 1;
                }
                else _Age = value;
            }
        }
        public string Breed { get { return _Breed; } set { _Breed = value; } }
        public string Eating()
        {
            return ($"{_Name} the {_Species} is eating... Munch munch crunch crunch \n");
        }

        public string Sleeping()
        {
            return ($"{_Name} the {_Species} is sleeping... \n");
        }

        public string Mood
        {
            get { return _Mood; }
            set { _Mood = value; }
        }
        public string Bark()
        {
            return $"{_Name} the {_Mood} {_Breed} says, 'Woof'!\n";
        }

        public string WagTail()
        {
            return $"{_Name} the {_Mood} {_Species}'s tail is wagging...\n";
        }

        public string Purr()
        {
            return $"{_Name} the {_Mood} {_Breed} is purring...\n";
        }

        public string Meow()
        {
            return $"{_Name} the {_Mood} {_Species} is meowing...\n";
        }




    }
}
