using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UfoSpawner : MonoBehaviour {

	private float nextSpawn = 10;
	public Transform prefabToSpawn;
	public float spawnRate = 1;
	public float randomDelay = 50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn) {
			Instantiate (prefabToSpawn, transform
				.position, Quaternion.identity);
			nextSpawn = Time.time + spawnRate + Random.Range (0, randomDelay);
		}
	}
}
