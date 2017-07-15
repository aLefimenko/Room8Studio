using Assets.Scripts.Controlled_animals;
using Assets.Scripts.ScriptForAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Dog: AnimalBase
    {
        private GameObject prefabOfDog;

        void Start()
        {
            prefabOfDog = GameObject.FindGameObjectWithTag("cow");
            controllAnimal = new Controll();
        }

        public override bool Controll()
        {
            return controllAnimal.Controll();
        }

        public override void InstaitiateAnimals(GameObject _prefab, int _count)
        {
            for (int j = 0; j < _count; j++)
            {
                GameObject dog = (GameObject)Instantiate(_prefab, new Vector2(UnityEngine.Random.Range(-6f, 6f), UnityEngine.Random.Range(-3.5f, 3.5f)), Quaternion.identity);
                dog.AddComponent<DogControll>();
            }
        }
    }
}
