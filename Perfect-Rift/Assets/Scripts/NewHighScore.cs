using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHighScore : MonoBehaviour
{
    float score, highScore;
    public GameObject nhs;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
        score = GameObject.Find("TimeManager").GetComponent<TimeKeeper>().t;

        if (score < highScore)
        {
            nhs.SetActive(true);
        }

        if (highScore == 0)
        {
            nhs.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
