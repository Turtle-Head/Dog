using DocumentFormat.OpenXml.Office.CoverPageProps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOG
{
    internal class Dog
    {
        //fields
        private string _name;
        private int _age;
        private string _breed;
        public Dog(string name, int age, string breed) 
        {
            _name = name;
            _age = age;
            _breed = breed;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set {
                if (value < 0 || value > 25)
                {
                    _age = 1;
                }
                else _age = value;
                } 
        }
        public string Breed { get { return _breed; } set { _breed = value; } }


//Methods
public string Bark()
        {
            return $"{Name} the {Breed} says, 'Woof'!\n";
        }
        public string WagTail()
        {
            return $"{Name}'s tail is wagging...\n";
        }


}
}
