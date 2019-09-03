using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet: MonoBehaviour {
	
	public float speed;
	public GameObject firstPos;
	public GameObject thisPos;
	public float bulletTime = 1f;
	public GameObject thisObject;

	void Start () 
	{
	    thisPos.transform.position	= firstPos.transform.position;
	    StartCoroutine(BulletDespawn());
	}
	
	void Update () 
	{
			transform.Translate(Vector3.right * Time.deltaTime * speed);			
	}
	
	 IEnumerator BulletDespawn ()
	{
        yield return new WaitForSeconds(bulletTime);
		thisObject.SetActive(false);
	}
	
}
