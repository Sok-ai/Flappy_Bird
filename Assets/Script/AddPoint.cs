using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPoint : MonoBehaviour
{

    public Text scoreText;
    private int Score = 0;

    void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        scoreText.text = Score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Point")
        {
            Score++;
        }
    }
}