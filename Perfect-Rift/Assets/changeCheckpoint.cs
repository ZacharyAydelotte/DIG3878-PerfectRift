using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCheckpoint : MonoBehaviour
{
    public GameObject prevDeathFloor;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
            Destroy(prevDeathFloor);
        Destroy(gameObject);
    }
}
