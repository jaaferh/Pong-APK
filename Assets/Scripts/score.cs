using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour
{
    // Variables
    public TextMesh currentScore;
    public GameObject pongPref; // to destroy ball and replace it to starting pos
    public Transform barObject;

    private GameObject pong;
    private int scoreInt;

    // Update is called once per frame
    void Update()
    {
            pong = GameObject.FindGameObjectWithTag("Pong");
            currentScore.text = scoreInt.ToString();
    }

    void OnTriggerEnter(Collider other)  // when rigidbody hits boxcollider, this function is triggered. isTrigger must be enabled
    {
        if (other.tag == "Pong")
        {
            scoreInt++;
            Destroy(pong);
            // x, y, z, rotation
            (Instantiate(pongPref,
                new Vector3(barObject.transform.position.x, barObject.transform.position.y + 0.4F, 0),
                            Quaternion.identity) as GameObject).transform.parent = barObject;

        }
    }
}
