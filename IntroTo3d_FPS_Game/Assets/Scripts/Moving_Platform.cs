using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour
{
    public GameObject target = null;
    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {
        target = null;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            target = col.gameObject;
            offset = target.transform.position - transform.position;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        target = null;
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            target.transform.position = transform.position+offset;
        }
    }

}
