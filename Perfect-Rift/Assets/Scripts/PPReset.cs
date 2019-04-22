using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P) && Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.E) && Input.GetKeyDown(KeyCode.F))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
