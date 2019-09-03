using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour {
	
	//The speed at which the bullet will travel
	public float speed;
	//A game object in the 3D world of unity is a visually rendered 3D object. Game objects are assigned a position on 3 axis: X,Y,Z
	//By assigning this variable to a GameObject in the editor, we now have all the data stored in this GameObject including the position
	//We will use this to assign a starting position for the bullet
	public GameObject firstPos;
	//The current position of the bullet
	public GameObject thisPos;
	//The time the bullet will stay on the screen before it is deleted to prevent lag and garbage buildup. (This is put into action on line 29)
	public float bulletTime = 1f;
	//The object this script is attached to.
	public GameObject thisObject;

	void Start () 
	{
	    //This takes the bullets position, aligns it to the starting position to the bullet, and initiates the Coroutine that will destroy the bullet
	    thisPos.transform.position	= firstPos.transform.position;
	    StartCoroutine(BulletDespawn());
	}
	
	void Update () 
	{
	    //Moves the bullet by the speed of which we assign it to move by
	    transform.Translate(Vector3.right * Time.deltaTime * speed);			
	}
	
	 //Destroys the bullet after a set amount of time (defined in our bulletTime variable on line 16)
	 IEnumerator BulletDespawn ()
	{
        yield return new WaitForSeconds(bulletTime);
		thisObject.SetActive(false);
	}
	
}
