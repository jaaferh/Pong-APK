using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        transform.localScale *= 0.9F;
    }

    void OnMouseUp()
    {
        SceneManager.LoadScene("Game"); // opens the other scene (scene 0)
    }
}
