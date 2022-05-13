using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRespawn : MonoBehaviour
{
    public float maxTime = 1;
    private float interval = 0;
    public GameObject pipe;
    public float height;
    public GameObject obj;

    private void Start()
    {
        GameObject NewPipe = Instantiate(pipe);
        NewPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,height), 0);
    }

    private void Update()
    {
        if (interval > maxTime)
        {
            GameObject NewPipe  = Instantiate(pipe);
            NewPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,height), 0);
            Destroy(NewPipe, 6);
            interval = 0;
        }
        interval += Time.deltaTime;
    }
}
