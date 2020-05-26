using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 5;
    public float x;

    void Start()
    {
        x = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (x == -1)
            {
                x = x;
            }
            else
            {
                x--;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (x == 1)
            {
                x = x;
            }
            else
            {
                x++;
            }
        }
        if (x == -1)
        {
            gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(-4f, 0.5f, 0), speed * Time.deltaTime);
        }
        if (x == 0)
        {
            gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(0, 0.5f, 0), speed * Time.deltaTime);
        }
        if (x == 1)
        {
            gameObject.transform.localPosition = Vector3.MoveTowards(gameObject.transform.localPosition, new Vector3(4f, 0.5f, 0), speed * Time.deltaTime);
        }
    }
}





