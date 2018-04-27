using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    GameObject bridge;
	// Use this for initialization
	void Start () {
        bridge = GameObject.Find("Bridge1");
        bridge.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        bridge.SetActive(true);
        gameObject.SetActive(false);
       
    }
}
