using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongSwitch : MonoBehaviour {

    GameObject bridge1;
    GameObject bridge2;
    GameObject bridge3;
    // Use this for initialization
    void Start()
    {
        bridge1 = GameObject.FindGameObjectWithTag("StrongBridge");
        bridge1.SetActive(false);
        bridge2 = GameObject.FindGameObjectWithTag("StrongBridge2");
        bridge2.SetActive(false);
        bridge3 = GameObject.FindGameObjectWithTag("StrongBridge3");
        bridge3.SetActive(false);
    }

    // Update is called once per frame
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Top") || other.gameObject.CompareTag("Bottom"))
        {
            bridge1.SetActive(true);
            bridge2.SetActive(true);
            bridge3.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
