using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public bool isDead;

    public float velocity;
    public Rigidbody2D rb2D;

    public GameManager managerGame;
    public GameObject deathScreen;
    
    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * velocity; // Havada ku?u s??rat.
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name =="ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;
            deathScreen.SetActive(true);
        }
    }

}
