using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Top : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wood"))
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Destination"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level2");
        }
        if (other.gameObject.CompareTag("Destination2"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level3");
        }
        if (other.gameObject.CompareTag("Destination3"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level4");
        }

    }
}
