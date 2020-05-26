using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    public static int Score;
    public static int Point;
    public static int TotalScore;

    public Text ShowScore;

    void Start()
    {
        Score = 0;
        Point = 0;
    }

    void Update()
    {
        TotalScore = Score + Point;
        ShowScore.text = TotalScore.ToString();
    }
}
