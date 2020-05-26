using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpeed : MonoBehaviour
{
    public float MinSpeed = 4f;
    public float MaxSpeed = 6f;
    void Update()
    {
        transform.Translate(new Vector3(0, 0, -20f) * Random.Range(MinSpeed, MaxSpeed) * Time.deltaTime, Space.World);
        Destroy(gameObject, 15);
    }

}
