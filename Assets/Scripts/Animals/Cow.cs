using Assets.Scripts.Controlled_animals;
using Assets.Scripts.ScriptForAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    class Cow: AnimalBase
    {
        private GameObject prefabOfCow;

        void Start()
        {
            prefabOfCow = GameObject.FindGameObjectWithTag("cow");
            controllAnimal = new UnControll();
        }


        public override bool Controll()
        {
            return controllAnimal.Controll();
        }

        public override void InstaitiateAnimals(GameObject _prefab, int _count)
        {
            for(int j=0; j<_count;j++)
            {
                GameObject cow = (GameObject)Instantiate(_prefab, new Vector2(UnityEngine.Random.Range(-6f, 0), UnityEngine.Random.Range(0, 3.5f)), Quaternion.identity);
                cow.AddComponent<CowControll>();
            }
        }
    }
}
