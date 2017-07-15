using Assets.Scripts.Controlled_animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    class Cow: AnimalBase
    {
        private int CountOfCow;

        public Cow(int i)
        {
            CountOfCow = i;
            controllAnimal = new UnControll();
        }

        public override bool Controll()
        {
            return controllAnimal.Controll();
        }

    }
}
