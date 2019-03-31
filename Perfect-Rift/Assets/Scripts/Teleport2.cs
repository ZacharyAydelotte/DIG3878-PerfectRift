using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport2 : MonoBehaviour
{
    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(00);
        }
    }
}
