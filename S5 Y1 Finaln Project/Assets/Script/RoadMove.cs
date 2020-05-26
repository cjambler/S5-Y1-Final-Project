using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMove : MonoBehaviour
{
    public float speed = 2f;
    void Update()
    {
        transform.Translate(new Vector3 (0,0,-20f) * speed*Time.deltaTime, Space.World);
    }
}
