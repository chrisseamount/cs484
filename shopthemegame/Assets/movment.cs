using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour {

    public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("horizontal", movement.x);
        animator.SetFloat("vertical", movement.y);

        
        transform.position = transform.position + movement * Time.deltaTime;
       
    }
}
