using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScoreText, topRunnerText;
    public float highScore;
    public float score;
    public InputField tagInput;
    public GameObject inputField;
    string runnerTag;

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
        score = GameObject.Find("TimeManager").GetComponent<TimeKeeper>().t;
        //runnerTag = PlayerPrefs.GetString("TopRunner");
    }

    // Update is called once per frame
    void Update()
    {
        if (score < highScore)
        {
            highScore = score;
            PlayerPrefs.SetFloat("HighScore", highScore);
            //inputField.SetActive(true);          
        }

        highScoreText.text = ("Fastest Time: " + highScore);
        topRunnerText.text = ("Top Runner: " + runnerTag);
    }

    /*public void newHighScore()
    {
        runnerTag = tagInput.text;
        PlayerPrefs.SetString("TopRunner", runnerTag);
        inputField.SetActive(false);
    }*/
}
