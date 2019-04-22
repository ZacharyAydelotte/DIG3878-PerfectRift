using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourTime : MonoBehaviour
{
    public Text yourTimeText;

    // Start is called before the first frame update
    void Start()
    {
        float time = GameObject.Find("TimeManager").GetComponent<TimeKeeper>().t;
        string minutes = ((int)time / 60).ToString();
        string seconds = (time % 60).ToString("f2");
        yourTimeText.text = "Your Time: " + minutes + ":" + seconds;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
