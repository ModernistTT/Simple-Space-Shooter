using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeath : MonoBehaviour {
	
	public ParticleSystem deathEffect;
	public GameObject player;

	void Start () 
	{
		
	}
	

	void Update () 
	{
	}
	
	void OnTriggerEnter2D() 
	{
		player.SetActive(false);
		deathEffect.transform.position = player.transform.position;
		
		if (deathEffect != null)
		{
			deathEffect.Play(); 
		}	
	}
}
