using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowTriggerEnter : MonoBehaviour {

    void OnTriggerEnter(Collider col)
    {
        Debug.Log(col.tag);
        if(col.gameObject.tag=="cow")
        {
            Debug.Log("yeah");
            Destroy(col.gameObject, 0.5f);
        }
    }
}
