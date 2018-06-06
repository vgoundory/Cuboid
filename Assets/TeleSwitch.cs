using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleSwitch : MonoBehaviour {

    GameObject TeleCube1;
    GameObject TeleCube2;
    GameObject Player;


    // Use this for initialization
    void Start () {

        TeleCube1 = GameObject.Find("TeleCube1");
        TeleCube1.SetActive(false);
        TeleCube2 = GameObject.Find("TeleCube2");
        TeleCube2.SetActive(false);
        Player = GameObject.FindGameObjectWithTag("Player");




    }

    // Update is called once per frame
    void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Top") || other.gameObject.CompareTag("Bottom"))
            {
            TeleCube1.SetActive(true);
            TeleCube2.SetActive(true);

            gameObject.SetActive(false);
            Player.SetActive(false);
            
        }


    }
}
