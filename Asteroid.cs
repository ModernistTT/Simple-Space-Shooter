using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour {
	
	public float speed;


	void Start () 
	{
		
	}
	

	void Update () 
	{
		transform.Translate(Vector3.down * Time.deltaTime * speed);
	}
}
