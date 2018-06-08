using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public float myTimer = 60;
    private Text timerText;

    // Use this for initialization
    void Start()
    {
        timerText = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {
        myTimer -= Time.deltaTime;

        timerText.text = ("Time left : ") + myTimer.ToString("f0");
        if (myTimer < 0)
        {
            timerText.text = "Time up! You lost!";

            SceneManager.LoadScene("gameOver");
        }
        print(timerText);

    }
}
