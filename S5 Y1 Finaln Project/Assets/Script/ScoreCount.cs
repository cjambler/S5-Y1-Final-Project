using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    void OnTriggerEnter(Collider score)
    {
        if (score.gameObject.tag == "Car")
        {
            ScoreCode.Score = ScoreCode.Score + 3;
            Destroy(score.gameObject);
            print("Get Score");
        }
    }
}
