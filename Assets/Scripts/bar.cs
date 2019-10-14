using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{

    public float barSpeed = 1F;
    public Vector3 playerPos;
    private float factor = 8;

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1) {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved) {
                gameObject.transform.Translate(touch.deltaPosition.x / Screen.width * factor, 0.0f, 0.0f);
            }
        }

        // float xPos = gameObject.transform.position.x + (Input.GetAxis("Horizontal") * barSpeed);
        // playerPos = new Vector3 (Mathf.Clamp(xPos, -2, 2), -4, 0);
        // gameObject.transform.position = playerPos;
    }
}
