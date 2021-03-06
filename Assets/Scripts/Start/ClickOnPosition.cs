﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPosition : MonoBehaviour {

    private Vector2 clickPOsition;

    private List<GameObject> dogs = new List<GameObject>();


	void Start () {
        dogs.AddRange(GameObject.FindGameObjectsWithTag("dog"));
    }
	
	void Update () {
		if(clickPOsition!=Vector2.zero)
        {
            MoveToClick();
        }
	}

    void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        clickPOsition = new Vector2(ray.origin.x,ray.origin.y);
       // Debug.Log(clickPOsition.ToString());
    }



    void MoveToClick()
    {
        foreach(GameObject gameDog in dogs)
        {
            if(gameDog.GetComponent<SpriteRenderer>().color == Color.red)
            {
                
                gameDog.gameObject.transform.position = Vector3.MoveTowards(gameDog.transform.position, new Vector3(clickPOsition.x, clickPOsition.y, gameDog.transform.position.z), 2f * Time.deltaTime);
            }
            if(gameDog.transform.position.x==clickPOsition.x&&gameDog.transform.position.y==clickPOsition.y)
            {
                clickPOsition = Vector2.zero;
                gameDog.GetComponent<SpriteRenderer>().color = Color.white;
            }
            
        }
    }
}
