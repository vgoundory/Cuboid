using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour {

    public float myTimer = 5;
    private Text timerText;

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();

		
	}
	
	// Update is called once per frame
	void Update () {
        myTimer -= Time.deltaTime;
        
        timerText.text = ("Time left : ") + myTimer.ToString("f0");
        print(timerText);
        if (myTimer < 0)
        {
            timerText.text = "Time up! You lost!";
            Wait();
            SceneManager.LoadScene("gameOver");
        }

    }
    IEnumerator Wait()
    {
        Debug.Log(2);
        yield return new WaitForSeconds(3);
        Debug.Log(3);
    }
}
