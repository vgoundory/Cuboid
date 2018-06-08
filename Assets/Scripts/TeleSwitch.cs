using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleSwitch : MonoBehaviour {

    GameObject Player;
    GameObject TeleCubes;



    // Use this for initialization
    void Start() {


        TeleCubes = GameObject.Find("TeleCubes");
        TeleCubes.SetActive(false);

        Player = GameObject.FindGameObjectWithTag("Player");




    }

    // Update is called once per frame
    void Update () {
        {
            
        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Top") || other.gameObject.CompareTag("Bottom"))
            {
            Player.SetActive(false);
            TeleCubes.SetActive(true);


            gameObject.SetActive(false);
           
            




        }


    }
}
