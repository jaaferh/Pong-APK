using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public float speed = 8;
    private Vector3 targetPos;
    private Vector3 playerPos;
    GameObject pongObj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pongObj = GameObject.FindGameObjectWithTag("Pong");
        if(pongObj != null)
        {
            // lowercase gameObject refers to this gameObject (the enemy)
            targetPos = Vector3.Lerp(gameObject.transform.position, pongObj.transform.position, Time.deltaTime * speed);
            playerPos = new Vector3 (Mathf.Clamp(targetPos.x, -2.75F, 2.75F), -4, 0);
            gameObject.transform.position = new Vector3(playerPos.x, 4, 0);
        }
    }
}
