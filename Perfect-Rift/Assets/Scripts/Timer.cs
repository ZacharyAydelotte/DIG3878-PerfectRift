using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float time = GameObject.Find("TimeManager").GetComponent<TimeKeeper>().t;
        string minutes = ((int) time / 60).ToString();
        string seconds = (time % 60).ToString("f2");
        timerText.text = "Time: " + minutes + ":" + seconds;

        DontDestroyOnLoad(this.gameObject);
    }
}
