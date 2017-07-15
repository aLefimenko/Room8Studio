using Assets.Scripts.Controlled_animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public abstract class AnimalBase
    {
        protected IControllable controllAnimal;
        int countAnimals;

        public AnimalBase()
        {
            controllAnimal = new UnControll();
            countAnimals = 10;
        }

        public virtual bool Controll()
        {
            return controllAnimal.Controll();
        }
    }
}
