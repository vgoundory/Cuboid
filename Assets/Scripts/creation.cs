using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creation : MonoBehaviour {

    public GameObject tile;

    GameObject[] spawn = new GameObject[1];


	// Use this for initialization
	void Start () {
		for (int i=0; i < spawn.Length; i++)
        {
            GameObject spawn = Instantiate(tile);
            

            spawn.transform.position = new Vector3(i, spawn.transform.position.y);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
