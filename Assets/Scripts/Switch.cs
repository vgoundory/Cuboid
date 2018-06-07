using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

    GameObject bridge_1;
    GameObject bridge_2;
    GameObject bridge_3;

    // Use this for initialization
    void Start () {
        bridge_1 = GameObject.FindGameObjectWithTag("Bridge1");
        bridge_1.SetActive(false);

        bridge_2 = GameObject.FindGameObjectWithTag("Bridge2");
        bridge_2.SetActive(false);

        bridge_3 = GameObject.FindGameObjectWithTag("Bridge3");
        bridge_3.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        bridge_1.SetActive(true);
        bridge_2.SetActive(true);
        bridge_3.SetActive(true);

        gameObject.SetActive(false);
       
    }
}
