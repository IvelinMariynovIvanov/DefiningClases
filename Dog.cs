using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClases
{
    class Dog
    {
        public string name;
        public string breed;
        public const string defaultName = null;
        public const string defaultBred = null;

        public Dog(): this(defaultName, defaultBred)
        {

        }

        public Dog (string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name { get; set; }
        public string  Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine(" A dog {0} wiht breed {1} said bauuu", 
                this.Name ?? "[unnamed dog]", this.Breed ?? "[unknow dog]");
        }
    }
}
