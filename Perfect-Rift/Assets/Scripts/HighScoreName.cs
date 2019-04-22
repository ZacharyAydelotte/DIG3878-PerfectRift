using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreName : MonoBehaviour
{
    public Text runnerTag;
    string nameTag;
    float score, highScore;
    public InputField tagInput;
    public GameObject inputField;

    // Start is called before the first frame update
    void Start()
    {
        nameTag = PlayerPrefs.GetString("TopRunner");
        highScore = PlayerPrefs.GetFloat("HighScore");
        score = GameObject.Find("TimeManager").GetComponent<TimeKeeper>().t;

        if (score < highScore)
        {
            inputField.SetActive(true);
        }

        if (highScore == 0)
        {
            inputField.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        runnerTag.text = "Top Runner: " + nameTag;
    }

    public void newHighScore()
    {
        nameTag = tagInput.text;
        PlayerPrefs.SetString("TopRunner", nameTag);
        
    }

    public void hideInput()
    {
        inputField.SetActive(false);
    }
}
