using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pong : MonoBehaviour
{
    // Variables
    public float pongVelocity = 1000;

    Rigidbody rb;
    bool isMoving; // automatically false
    int randInt;

    // Awake called when object is created
    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        randInt = Random.Range(1,3);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 1 && isMoving == false)
        {
            transform.parent = null;
            isMoving = true;
            rb.isKinematic = false;

            if(randInt == 1)
            {
                rb.AddForce(new Vector3(pongVelocity, pongVelocity, 0));
            }
            if(randInt == 2)
            {
                rb.AddForce(new Vector3(-pongVelocity, pongVelocity, 0));
            }
        }
    }
}
