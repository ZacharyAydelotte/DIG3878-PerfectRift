using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("TimeManager").GetComponent<TimeKeeper>().recording = false;
        GameObject.Find("TimeManager").GetComponent<TimeKeeper>().t = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
