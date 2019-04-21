using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloadDeBug : MonoBehaviour
{
    int nextSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.U) && Input.GetKeyDown(KeyCode.P))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

        if (Input.GetKey(KeyCode.M) && Input.GetKey(KeyCode.O) && Input.GetKey(KeyCode.R) && Input.GetKeyDown(KeyCode.E))
        {
            GameObject.Find("RigidBodyFPSController").GetComponent<TimeRev>().rwCounter += 5;
        }

        if (Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.X) && Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
