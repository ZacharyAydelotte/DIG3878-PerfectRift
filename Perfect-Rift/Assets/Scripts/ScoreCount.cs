using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{

    public static int gscore = 0;
    public Text scoreText;
    public GameObject warp;

    private void Awake()
    {
        gscore = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + gscore;

        if (gscore == 5)
        {
                warp.SetActive(true);

        }
    }

}
