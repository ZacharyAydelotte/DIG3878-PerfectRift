using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RWCounter : MonoBehaviour
{
    public Text rwText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int rwCount = GameObject.Find("RigidBodyFPSController").GetComponent<TimeRev>().rwCounter;

        rwText.text = "Rewinds x" + rwCount;

        if (rwCount <= 0)
        {
            rwText.color = new Color(1, 0, 0);
        }
    }
}
