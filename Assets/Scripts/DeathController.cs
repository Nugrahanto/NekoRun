using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Title");
        }
    }

    public void StartGame()
    {
        Application.LoadLevel("Games");
    }
}
