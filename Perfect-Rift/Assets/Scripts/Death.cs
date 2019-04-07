using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Death : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (gameObject.transform.position.y < -300)
        {
            SceneManager.LoadScene(sceneName: "Level2");
        }
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "Hazard")
        {
            SceneManager.LoadScene(sceneName: "Level1");
        }

    }



}
