using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathLevel3 : MonoBehaviour
{

    void Start()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (gameObject.transform.position.y < -300)
        {
            SceneManager.LoadScene(sceneName: "Level3");
        }
    }
}
