using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog firstDog = new Dog();
            Dog secondDog = new Dog("Sharo", "Melez");

            firstDog.Name = "ivo";
            firstDog.Breed = "Monster";

            firstDog.Bark();
            secondDog.Bark();
            firstDog.Bark();

        }
    }
}
