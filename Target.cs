using UnityEngine;

public class Target : MonoBehaviour {

    //This script allows the player to be able to shoot the enemies (Unfortunately I was unable to recover the gun script)
    //The amount of health the enemy has
    public float health = 50f;

    //If the health is below 0, destroy this object
    public void TakeDamage (float amount)
    {
        health -= amount;
         if (health <= 0f)            
        {
            //Calls the "death" function
            Die();            
        }
    }
    
    void Die ()
    {
        //Destroys the enemy
        Destroy(gameObject);
    }
}
