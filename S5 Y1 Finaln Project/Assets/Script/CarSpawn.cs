using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    public GameObject[] Cars;
    public Transform[] Points;
    public float WaitIntMin;
    public float WaitIntMax;

    void Start()
    {
        StartCoroutine(StartSpawn());
    }

    public void GameOver()
    {
        StopAllCoroutines();
    }


    IEnumerator StartSpawn()
    {
        while (true)
        {
            int Random_Objects = Random.Range(0, Cars.Length);
            int Random_Points = Random.Range(0, Points.Length);
            Instantiate(Cars[Random_Objects], Points[Random_Points].transform.position, Points[Random_Points].transform.rotation);
            yield return new WaitForSeconds(Random.Range(WaitIntMin, WaitIntMax));
        }
    }
}
