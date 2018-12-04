using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private string TargetName;// This variable will be used to determine who its intended to hit and spawned it

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void BulletSetup(string Target)
    {
        TargetName = Target;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag==TargetName)
        {
            Destroy(other.gameObject);
        }
        //Destroy(gameObject);
    }
}
