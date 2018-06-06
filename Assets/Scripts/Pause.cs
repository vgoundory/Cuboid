using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    public GameObject pauseButton, pausePanel;
	// put the rate at which the time passes in the game at 0.
    public void OnPause()
    {
        Time.timeScale = 0;
    }

    public void OnResume()
    {
        Time.timeScale = 1;
    }
}
