using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kupler : MonoBehaviour
{
    float x;
    float y;
    float z;
    Vector3 pos;

    void Start()
    {
        x = Random.Range(-10,10);
        y = 0.5f;
        z = Random.Range(-10,10);
        pos = new Vector3(x, y, z);
        transform.position = pos;

    }

    void Update()
    {
        transform.Rotate(new Vector3(15,30,45)*Time.deltaTime);
    }
}
