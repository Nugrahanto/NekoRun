using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveUFO : MonoBehaviour {

	public float speed = 10;
	public float jalan = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > jalan) {
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
}
