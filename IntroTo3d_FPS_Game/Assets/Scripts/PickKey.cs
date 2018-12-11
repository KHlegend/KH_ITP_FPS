using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickKey : MonoBehaviour
{
    public Component doorcolliderhere;
    public GameObject keyGone;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void onTriggerStay ()
    {
        if (Input.GetKey(KeyCode.E))
        {
            doorcolliderhere.GetComponent<BoxCollider>().enabled = true;
        }

        if (Input.GetKey(KeyCode.E))
        {
            keyGone.SetActive(false);
        }
	}
}
