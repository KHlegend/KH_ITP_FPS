using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hold_Object : MonoBehaviour
{
    public float speed = 10;
    public bool canHold = true;
    public GameObject ball;
    public Transform guide;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            if (!canHold)
                throw_drop();
            else
                Pickup();
            //ShootProjectile();
        }

        if (!canHold && ball)
            ball.transform.position = guide.position;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Target")
            if (!ball)
                ball = col.gameObject;
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Target")
        {
            if (canHold)
                ball = null;
        }
    }

    private void Pickup()
    {
        if (!ball)
            return;

        ball.transform.SetParent(guide);
        ball.GetComponent<Rigidbody>().useGravity = false;
        //ball.GetComponent<Rigidbody>().velocity = Vector3.zero;

        ball.transform.localRotation = transform.rotation;
        ball.transform.position = guide.position;

        canHold = false;
    }

    private void throw_drop()
    {
        Debug.Log("Throw");
        if (!ball)
            return;

        ball.GetComponent<Rigidbody>().useGravity = true;
        ball.GetComponent<Rigidbody>().velocity = transform.forward * speed;
       


        ball.transform.parent = null;
        canHold = true;
        ball = null;
    } 
}
