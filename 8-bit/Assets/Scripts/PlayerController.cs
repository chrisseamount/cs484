using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public SpawnObjects spawnObjects;

    public Animator animator;
    public Text scoreText;
    public Text timerText;

    public float speed;

    public float score;
    public float timer = 60.0f;

    private void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        timerText.text = "Time Remaining: " + timer.ToString();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);

        animator.SetFloat("horizontal", movement.x);

        transform.position = transform.position + movement * Time.deltaTime * speed;
    }

    private void Update()
    {
        if (timer <= 0f)
        {
            timerText.text = "Game Over!\nPress 'Escape' to Exit\nPress 'R' to Restart";
            spawnObjects.alive = false;
            GameObject[] fruits;
            fruits = GameObject.FindGameObjectsWithTag("Fruit");
            foreach(GameObject fruit in fruits)
            {
                Destroy(fruit);
            }
            Destroy();
            return;
        }

        scoreText.text = "Score: " + score.ToString();
   
        timer -= Time.deltaTime;
        timerText.text = "Time Remaining: " + timer.ToString("0");
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Fruit")
        {
            Destroy(collision.gameObject);
            score += 1;
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
