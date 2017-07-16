using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


class CowControll:MonoBehaviour
{

    private bool trigger = false;

    private GameObject dogInTrigger;

    void OnTriggerEnter(Collider col)
    {
        dogInTrigger = col.gameObject;
        trigger = true;
        //Debug.Log(this.tag);
    }

    void Update()
    {
        if(trigger==true)
        {
            gameObject.transform.position = Vector3.MoveTowards(this.transform.position, dogInTrigger.transform.position, 2f * Time.deltaTime);
        }
    }

}

