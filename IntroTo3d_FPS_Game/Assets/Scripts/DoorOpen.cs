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
	void OnTriggerStay (Collider other)
    {
        Debug.Log(other.gameObject.name.ToString());
        if (other.gameObject.GetComponent<Hold_Object>() != null)
        {
            if (Input.GetKey(KeyCode.O) && other.gameObject.GetComponent<Hold_Object>().keyActive != false)
            {

                doorhere.Play();
                other.gameObject.GetComponent<Hold_Object>().keyActive = false;

            }
        }
	}
}
