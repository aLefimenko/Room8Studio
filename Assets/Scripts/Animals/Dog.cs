using Assets.Scripts.Controlled_animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class Dog: AnimalBase
    {
        private int CountOfCow;

        public Dog(int i)
        {
            CountOfCow = i;
            controllAnimal = new Controll();
        }

        public override bool Controll()
        {
            return controllAnimal.Controll();
        }

    }
}
