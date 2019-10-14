using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public PlayerController playerController;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Fruit")
        {
            if(playerController.score != 0)
            {
                playerController.score -= 1;
            }
            Destroy(collision.gameObject);
        }
    }
}
