using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    //[SerializeField] private AudioSource jumpSound;

    [SerializeField] private GameObject PanelLose;
    [SerializeField] private GameObject PanelPoint;

    private void Update()
    {
       if (Input.GetMouseButtonDown(0))
        {
            jump();
            //jumpSound.Play();
        }
    }

    private void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0.01f, 0f);
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Block")
        {
            PanelLose.SetActive(true);
            PanelPoint.SetActive(false);
            Time.timeScale = 0;
        }
    }
}
