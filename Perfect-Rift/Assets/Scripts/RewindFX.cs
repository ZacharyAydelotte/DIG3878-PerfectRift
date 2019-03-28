using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PostProcessing;

public class RewindFX : MonoBehaviour
{
    public PostProcessingProfile rwFX, normalFX;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<PostProcessingBehaviour>().profile = normalFX;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GetComponent<PostProcessingBehaviour>().profile = rwFX;
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            GetComponent<PostProcessingBehaviour>().profile = normalFX;
        }
    }
}
