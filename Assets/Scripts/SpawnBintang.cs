using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBintang : MonoBehaviour {

	private float nextSpawn = 20;
	public Transform prefabToSpawn;
	public float spawnRate = 3;
	public float randomDelay = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawn) {
			Instantiate (prefabToSpawn, transform.position, Quaternion.identity);
			nextSpawn = Time.time + spawnRate + Random.Range (0, randomDelay);
		}
	}
}
