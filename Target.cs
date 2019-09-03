using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 50f;

 //what makes the damage work
    public void TakeDamage (float amount)
    {
        health -= amount;
         if (health <= 0f)            
        {
            Die();            
        }
    }
    
    void Die ()
    {
        Destroy(gameObject);
    }
}