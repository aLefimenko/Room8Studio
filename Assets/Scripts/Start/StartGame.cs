using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.Start
{
    class StartGame:MonoBehaviour
    {
        public int CountsCows;
        public int CountsDogs;

        public GameObject prefabOfCows;
        public GameObject prefabOfDogs;

        private Cow cowComponent;
        private Dog dogComponent;

        void Start()
        {
            gameObject.AddComponent<Cow>();
            gameObject.AddComponent<Dog>();
            cowComponent = gameObject.GetComponent<Cow>();
            dogComponent = gameObject.GetComponent<Dog>();
            cowComponent.InstaitiateAnimals(prefabOfCows, CountsCows);
            dogComponent.InstaitiateAnimals(prefabOfDogs, CountsDogs);
        }
        
        
    }
}
