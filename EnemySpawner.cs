using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	
	//The enemy
	public GameObject enemy;
        //A float value that will be randomly created on a range of -16.16 to 1
	float randx;
	//This will be the position our enemies will be created at. The randomly generated value from the float above will be assigned to this position, making the enemies spawn in a random spot
	Vector2 spawnPlace;
	//How often our enemies will appear
	public float spawnRate = 2f;
	//The time before we create another enemy
	float nextSpawn = 0f;
	
	void Start () 
	{
		
	}
	
	void Update () 
	{
	    if (Time.time > nextSpawn)	
	    {
			//Creates an enemy on a random position, and resets the time before creating another enemy
		        nextSpawn = Time.time + spawnRate;
			randx = Random.Range(-16.16f, 1f);
			spawnPlace = new Vector2 (randx, transform.position.y);
			Instantiate (enemy, spawnPlace, Quaternion.identity);
		}	
	}
}
