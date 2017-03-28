using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BintangMove : MonoBehaviour {

	public float speed = 15;
	public float jalan = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > jalan) {
			transform.position += Vector3.left * speed * Time.deltaTime;
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
	}
}
