using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour {
	public Text score1;
	public int score2;

	void scoreis()
	{
		
		score1.text = "Score:" + score2.ToString ();

	}
	void Start()
	{
		
		score2 = 0;
		scoreis();

	
	}
	void Update() {
		if (Input.GetKeyDown (KeyCode.UpArrow))
			score2++;
			

		else if (Input.GetKeyDown(KeyCode.DownArrow))
			score2++;

		else if (Input.GetKeyDown(KeyCode.RightArrow))
			score2++;

		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			score2++;

		scoreis();
	}
}

