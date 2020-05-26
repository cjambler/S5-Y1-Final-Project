using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CrashCheck : MonoBehaviour
{
    int countS = 0;
    public GameObject gameOverCanvasPrefab;
    void Start()
    {
        InvokeRepeating("countScore", 0.5f, 0.5f);
    }

    void countScore()
    {
        countS++;
        ScoreCode.Point = +countS;
    }


    void OnTriggerEnter(Collider crash)
    {
        if (crash.gameObject.tag == "Car")
        {
            GameObject[] cars = GameObject.FindGameObjectsWithTag("Car");
            foreach (GameObject car in cars) GameObject.Destroy(car);
            Destroy(crash.gameObject);
            GameObject.Find("Spawn Point").GetComponent<CarSpawn>().GameOver();
            CancelInvoke();
            Instantiate (gameOverCanvasPrefab, Vector2.zero, Quaternion.identity);
        }
    }

}
