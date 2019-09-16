using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transforms : MonoBehaviour {

    [Range(0, 1)]
    public float scale;

    public float speed;
    public float rspeed;

    private Rigidbody rb;

    public Transform target;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localScale += new Vector3(scale, scale, scale);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localScale -= new Vector3(scale, scale, scale);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.position = rb.transform.position + (rb.transform.rotation * new Vector3(0, 0, speed)) * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.RotateAround(rb.transform.position, Vector3.up, -rspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.RotateAround(rb.transform.position, Vector3.up, rspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.position = rb.transform.position - (rb.transform.rotation * new Vector3(0, 0, speed)) * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.LookAt(target);

        }
    }
}
