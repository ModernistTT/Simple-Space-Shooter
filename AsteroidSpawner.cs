using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour {
	
	public GameObject enemy;
    float randx;
	Vector2 spawnPlace;
	public float spawnRate = 2f;
	float nextSpawn = 0f;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
	    if (Time.time > nextSpawn)	
	    {
			nextSpawn = Time.time + spawnRate;
			randx = Random.Range(19.52f, 5.19f);
			spawnPlace = new Vector2 (randx, transform.position.y);
			Instantiate (enemy, spawnPlace, Quaternion.identity);
		}	
	}
}
