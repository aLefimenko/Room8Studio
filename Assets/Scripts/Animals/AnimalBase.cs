
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


    public abstract class AnimalBase: MonoBehaviour
    {
        protected IControllable controllAnimal;

        void Start() { 
            controllAnimal = new UnControll();
        }

        public abstract bool Controll();
        public abstract void InstaitiateAnimals(GameObject prefab, int count);
    }

