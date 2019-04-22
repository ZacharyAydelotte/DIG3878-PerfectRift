using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeper : MonoBehaviour
{
    public float t;
    public bool recording;

    // Start is called before the first frame update
    void Start()
    {
        recording = true;
        t = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (recording)
        {
            t += Time.deltaTime;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
