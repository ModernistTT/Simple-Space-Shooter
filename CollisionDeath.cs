using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDeath : MonoBehaviour {
	
	//A Particle system (or particle effect) is a effect that can be used to create explosions, water from a waterfall, rain & more.
	//A particle system takes a special type texture, and can duplicate that texture in to 3D "particles"
	public ParticleSystem deathEffect;
	//Our player
	public GameObject player;

	void Start () 
	{
		
	}
	

	void Update () 
	{
	}
	
	
	void OnTriggerEnter2D() 
	{
		//Destroys the player GameObject, moves the explosion effect to the player's position, 
		player.SetActive(false);
		deathEffect.transform.position = player.transform.position;
		
		//If a particle effect is assigned, the effect will render, however if an effect is not assigned, instead of creating an error, it instead ignores this line
		if (deathEffect != null)
		{
			deathEffect.Play(); 
		}	
	}
}
