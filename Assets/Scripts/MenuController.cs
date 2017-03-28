using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

//	public Text txtBestScore;

    // Use this for initialization
    

    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
	}

	public void StartGame(){
		//Application.LoadLevel("Games");
		SceneManager.LoadScene("Games");
	}

	public void About(){
		SceneManager.LoadScene("About");
	}

	public void doquitt(){
		Debug.Log ("has quit game");
		Application.Quit ();
	}
}
