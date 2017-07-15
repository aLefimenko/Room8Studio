
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


    class Cow: AnimalBase
    {

        void Start()
        {
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
                GameObject cow = (GameObject)Instantiate(_prefab, new Vector2(UnityEngine.Random.Range(-6f, 0), UnityEngine.Random.Range(-3f, 0)), Quaternion.identity);
                cow.AddComponent<CowControll>();
            }
        }
    }

