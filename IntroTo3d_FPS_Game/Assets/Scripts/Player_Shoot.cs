using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletPrefab;
    [SerializeField]
    private Transform BulletSpawnPoint;
    [SerializeField]
    private float BulletSpeed;

    

    public GameObject respawnSpot;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ShootRayTrace();

		if (Input.GetMouseButtonDown(0))
        {
            //ShootProjectile();
        }
	}

    public void ShootRayTrace()
    {
        int layerMask = 1 << 8;
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(BulletSpawnPoint.position,BulletSpawnPoint.transform.TransformDirection(Vector3.forward), 
            out hit, Mathf.Infinity))
        {
            Debug.DrawRay(BulletSpawnPoint.position, BulletSpawnPoint.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        }
        else
        {
            Debug.DrawRay(BulletSpawnPoint.position, BulletSpawnPoint.transform.TransformDirection(Vector3.forward) * 100, Color.red);
        }

    }

    public void ShootProjectile()
    {// This function will create a bullet from the barrel of the gun.
        GameObject Bullet;
        Bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
        Bullet.GetComponent<Bullet>().BulletSetup("Target");
        Bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward*BulletSpeed;// this line applies velocity in the direction that the spawn point is facing
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Death>() != null)
        {
            transform.parent.position = respawnSpot.transform.position;
        }
    }

    
}
