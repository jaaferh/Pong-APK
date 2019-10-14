using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuPong : MonoBehaviour
{
    // Variables
    public int pongVel = 150;
    public Rigidbody rb;

    void Awake()
    {
        rb.velocity = new Vector3(pongVel, pongVel, 0);
    }

}
