using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausebtn : MonoBehaviour {

	//bool Pause = false;
	public GameObject btnPause;
	public GameObject btnPlay;
	public bool paused;

	// Use this for initialization
	void Start () {
		paused = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pause () {

		paused = !paused;

			if (Time.timeScale == 1)
			{
				Time.timeScale = 0;
				btnPause.SetActive (false);
				btnPlay.SetActive (true);
			}
			else
			{
				Time.timeScale = 1;
				btnPause.SetActive (true);
				btnPlay.SetActive (false);
			}
	}  
}
