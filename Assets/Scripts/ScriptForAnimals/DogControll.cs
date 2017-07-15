using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEditor;

class DogControll:MonoBehaviour
{
    private bool isChecked;

    void Start()
    {
        isChecked = false;
    }

    void OnMouseDown()
    {
        if (isChecked == false)
        {
            isChecked = true;
            gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else
        {
            isChecked = false;
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}

 