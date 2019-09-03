using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The line above lets the compiler know we are using the Unity API.

public class Asteroid : MonoBehaviour {
	
	//A float which configures the speed that the asteriods/enemy spaceships fall at. The value can be changed in the unity editor.
	public float speed;

        //In unity, a void by the name of start will execute the line of code contained in that void when the game starts.
	void Start () 
	{
		
	}
	
        //The update void executes this line of code once every frame
	void Update () 
	{
		//This line moves the parent object containing this script.
		transform.Translate(Vector3.down * Time.deltaTime * speed);
	}
}
