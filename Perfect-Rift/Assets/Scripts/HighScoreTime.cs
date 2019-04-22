using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTime : MonoBehaviour
{
    public Text highScoreText;
    public float highScore, score;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
        score = GameObject.Find("TimeManager").GetComponent<TimeKeeper>().t;
    }

    // Update is called once per frame
    void Update()
    {
        if (score < highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("HighScore", highScore);        
        }

        if (highScore == 0)
        {
            highScore = score;
            PlayerPrefs.SetFloat("HighScore", highScore);
        }

        string minutes = ((int)highScore / 60).ToString();
        string seconds = (highScore % 60).ToString("f2");
        highScoreText.text = "Fastest Time: " + minutes + ":" + seconds;
    }
}
