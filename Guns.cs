using UnityEngine;
using System.Collections;

 

public class Guns : MonoBehaviour {
    
    public float damage = 100f;
    public float range = 500f;
    public float hitForce = 30f;
    public float fireRate = 15f;
    public AudioSource gunshotSound;
    public GameObject bullet;
    public int maxAmmo = 999;
    private int currentAmmo;
    public float reloadTime = 1f;
    private bool IsReloading = false;
	private float bulletTime = 10f;
    
    
    public GameObject cam;
    public ParticleSystem muzzleFlash;
    
    private float nextTimeToFire = 0f;
    

    void Start () {

     currentAmmo = maxAmmo;
    }
    
    
    void Update () {    
        
        if (IsReloading)
            return;
        
        if (currentAmmo <=0f)
        {    
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f/fireRate;
            gunshotSound.Play();
            Shoot();
            muzzleFlash.Play();  
			GameObject duplicate = Instantiate(bullet);
			duplicate.SetActive(true);
        }
    

    }
    
    IEnumerator Reload ()
    {
        IsReloading = true;
        
        Debug.Log ("Reloading...");
        
        yield return new WaitForSeconds(reloadTime);
        
        currentAmmo = maxAmmo;
        IsReloading = false;
    }
    
    void Shoot ()
    {
        
        currentAmmo--;
    
         RaycastHit hit;
         if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range)) 
         { 
              Debug.Log(hit.transform.name);
              
              Target target = hit.transform.GetComponent<Target>();
              if (target != null)
              {
                  target.TakeDamage(damage);
              }
             
             if (hit.rigidbody != null)
             {
                hit.rigidbody.AddForce (-hit.normal * hitForce);
             }     
         }        
    } 
}