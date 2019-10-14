using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] items;

    public float startTime = 1.0f;
    private float currentTime;

    public bool alive;

    private void Start()
    {
        alive = true;
    }

    private void Update()
    {
        if(alive == false)
        {
            Destroy(gameObject);
        }
        
        if (currentTime <= 0)
        {
            int randLocation = Random.Range(0, spawnLocations.Length);
            int randItem = Random.Range(0, items.Length);

            Vector2 newPos = new Vector2(spawnLocations[randLocation].position.x, transform.position.y);
            transform.position = newPos;

            Instantiate(items[randItem], transform.position, Quaternion.identity);

            currentTime = startTime;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }


        
      
        
    }

}
