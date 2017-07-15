using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts.ScriptForAnimals
{
    class DogControll:MonoBehaviour
    {
        private bool dogControlled;

        void Start()
        {
            dogControlled = false;
            //Debug.Log("yeah");
        }

        void OnMouseDown()
        {
            Debug.Log("monah");
            dogControlled = true;
        }

        void Update()
        {
            if(dogControlled==false)
            {
                Debug.Log("yeah");
                dogControlled = true;
            }
        }

    }
}
