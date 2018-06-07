using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    GameObject bridge;
    GameObject bridge2;
    GameObject bridge3;

    // Use this for initialization
    void Start () {
        bridge = GameObject.FindGameObjectWithTag("Bridge1");
        bridge.SetActive(false);

        bridge2 = GameObject.FindGameObjectWithTag("Bridge2");
        bridge2.SetActive(false);

        bridge3 = GameObject.FindGameObjectWithTag("Bridge3");
        bridge3.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        bridge.SetActive(true);
        bridge2.SetActive(true);
        bridge3.SetActive(true);

        gameObject.SetActive(false);
       
    }
}
