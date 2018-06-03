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
        if (other.gameObject.CompareTag("Destination4"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level5");
        }
        if (other.gameObject.CompareTag("Destination5"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level6");
        }
        if (other.gameObject.CompareTag("Destination6"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level7");
        }
        if (other.gameObject.CompareTag("Destination7"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level8");
        }
        if (other.gameObject.CompareTag("Destination8"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level9");
        }
        if (other.gameObject.CompareTag("Destination9"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("Level10");
        }
        if (other.gameObject.CompareTag("Destination10"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("gameOver");
        }

    }
}
