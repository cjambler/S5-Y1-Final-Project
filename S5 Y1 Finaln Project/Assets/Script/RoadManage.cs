using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManage : MonoBehaviour
{
    public Road road1;
    public Road road2;
    public GameObject[] roads;
    public static RoadManage _instance;
    void Awake()
    {
        _instance = this;
    }
    void Start()
    {
        InvokeRepeating("GenerateRoad", 0f, 2.5f);
    }

    public void GenerateRoad()
    {
        int type = Random.Range(0, roads.Length);
        GameObject newRoad = Instantiate(roads[type], new Vector3(0, 0, 350f), Quaternion.identity) as GameObject;
        road1 = road2;
        road2 = newRoad.GetComponent<Road>();
    }

}
