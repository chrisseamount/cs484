using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float rspeed;

    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
     
    }

    void FixedUpdate()
    {
        if(Input.GetKey (KeyCode.UpArrow))
        {
            rb.transform.position = rb.transform.position + (rb.transform.rotation * new Vector3(0, 0, speed)) * Time.deltaTime;
           
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.RotateAround (rb.transform.position, Vector3.up, -rspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.RotateAround(rb.transform.position, Vector3.up, rspeed * Time.deltaTime);
        }
    }
}