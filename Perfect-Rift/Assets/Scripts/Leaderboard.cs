using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    public Text text, gTag, time;
    string runnerTag;
    float highScore;

    // Start is called before the first frame update
    void Start()
    {
        runnerTag = PlayerPrefs.GetString("TopRunner");
        highScore = PlayerPrefs.GetFloat("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Top Runner";
        gTag.text = runnerTag;
        time.text = highScore.ToString("f2");
    }
}
