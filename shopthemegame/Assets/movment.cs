using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour {

    public Animator animator;

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("magnitude", movement.magnitude);

        if(movement.x == 0f && movement.y == 0f)
        {
            
        }
        else
        {
            animator.SetFloat("lastx",movement.x);
            animator.SetFloat("lasty",movement.y);
        }
        
        transform.position = transform.position + movement * Time.deltaTime * speed;
       
    }
}
