using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverCanvas : MonoBehaviour
{
    public Text finalScoreText;
    private int score;
    void Start()
    {
        score = ScoreCode.TotalScore;
        finalScoreText.text = score.ToString() + " points";
    }

}
