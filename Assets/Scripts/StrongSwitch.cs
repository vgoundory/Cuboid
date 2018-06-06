using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrongSwitch : MonoBehaviour {

    GameObject bridge;
    // Use this for initialization
    void Start()
    {
        bridge = GameObject.Find("StrongBridge");
        bridge.SetActive(false);
    }

    // Update is called once per frame
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Top") || other.gameObject.CompareTag("Bottom"))
        {
            bridge.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
