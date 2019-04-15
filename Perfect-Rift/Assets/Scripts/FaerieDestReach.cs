using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaerieDestReach : MonoBehaviour
{
    public GameObject faerie;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Faerie")
        {
            faerie.SetActive(false);
            Debug.Log("touch");
        }
    }
}
