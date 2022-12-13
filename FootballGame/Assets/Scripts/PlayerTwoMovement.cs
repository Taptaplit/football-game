using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if (Input.GetKey("right")) {
            rb.AddForce(new Vector3(10, 0, 0));
        }
        if (Input.GetKey("left")) {
            rb.AddForce(new Vector3(-10, 0, 0));
        }
        if (Input.GetKey("up")) {
            rb.AddForce(new Vector3(0, 50, 0));
        }
    }
}
