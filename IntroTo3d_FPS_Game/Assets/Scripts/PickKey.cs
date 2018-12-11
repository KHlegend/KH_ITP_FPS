using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    public Component doorcolliderhere;
    //public GameObject keyGone;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other)
    {
        if (Input.GetKey(KeyCode.E) && other.gameObject.GetComponent<Hold_Object>() !=null)
        {
            
            doorcolliderhere.GetComponent<BoxCollider>().enabled = true;
            Destroy(gameObject);
            other.gameObject.GetComponent<Hold_Object>().keyActive = true;

            //keyGone.SetActive(false);
        }
	}
}
