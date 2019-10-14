using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    // Variables
    public GameObject pong;

    private float randX;
    private float randY;




    // Start is called before the first frame update
    void Start()
    {
        // Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        // Touch touch = Input.GetTouch(0);
        // if (touch.phase == TouchPhase.Moved) {
        if (Input.GetMouseButton(0))
        {
            Spawn();
        }
    }

    void Spawn()
    {
        CreateRandomPosition();
        Instantiate(pong, new Vector3(randX, randY, 0), Quaternion.identity);
    }

    void CreateRandomPosition()
    {
        randX = Random.Range(-2.5F, 2.5F);
        randY = Random.Range(-4.5F, 4.5F);
    }
}
