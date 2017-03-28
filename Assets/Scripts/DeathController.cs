using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Application.LoadLevel("Title");
			SceneManager.LoadScene("Title");
        }
    }

    public void StartGame()
    {
        //Application.LoadLevel("Games");
		SceneManager.LoadScene("Games");
    }
}
