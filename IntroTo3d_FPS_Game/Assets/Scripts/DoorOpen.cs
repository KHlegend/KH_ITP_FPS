using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animation doorhere;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void onTriggerStay ()
    {
        if (Input.GetKey(KeyCode.O))
        {
            doorhere.Play();
        }
	}
}
