using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float _speed;
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
