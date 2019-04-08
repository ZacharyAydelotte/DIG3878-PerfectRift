using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicRW : MonoBehaviour
{
    AudioSource musicSource;
    int pitch = 1;

    // Start is called before the first frame update
    void Start()
    {
        musicSource = GetComponent<AudioSource>();
        musicSource.pitch = pitch;

        //GameObject.Find("RigidBodyFPSController").GetComponent<TimeRev>().isRewinding;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("RigidBodyFPSController").GetComponent<TimeRev>().isRewinding)
        {
            musicSource.pitch = -1;
        }
        else
        {
            musicSource.pitch = 1;
        }

        Debug.Log(musicSource.pitch);
    }
}
