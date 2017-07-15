
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


    class Dog: AnimalBase
    {
        void Start()
        {
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
                GameObject dog = (GameObject)Instantiate(_prefab, new Vector2(UnityEngine.Random.Range(2f, 6f), UnityEngine.Random.Range(0, 3.5f)), Quaternion.identity);
                dog.AddComponent<DogControll>();
            }
        }
    }

