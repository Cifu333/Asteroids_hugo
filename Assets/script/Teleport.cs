using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//sample text
public class Teleport : MonoBehaviour
{
    public float limit_x;
    public float limit_y;
    void Update()
    {
        if (transform.position.y > limit_y)
        {
        transform.position =new Vector3 (transform.position.x, -limit_y, transform.position.z);
        }

        if (transform.position.y < -limit_y)
        {
            transform.position = new Vector3(transform.position.x, limit_y, transform.position.z);
        }

    }
}
