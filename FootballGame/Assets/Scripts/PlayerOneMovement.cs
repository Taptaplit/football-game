using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour
{
    public CharacterController controller;
    public Rigidbody rb;
    public float speed = 6f;
    [SerializeField]
    public float jumpHeight = 30f;
    private Vector3 moveDir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        if (Input.GetKey("d")) {
            float horizontal = Input.GetAxisRaw("Horizontal");
            moveDir.x = horizontal * speed;
            float z = Input.GetAxisRaw("ZValue");
            moveDir.z = z;
            controller.Move(moveDir * Time.deltaTime);
        }
        if (Input.GetKey("a")) {
            float horizontal = Input.GetAxisRaw("Horizontal");
            moveDir.x = horizontal * speed;
            float z = Input.GetAxisRaw("ZValue");
            moveDir.z = z;
            controller.Move(moveDir * Time.deltaTime);
        }
        if (Input.GetKey("w")) {
            rb.AddForce(new Vector3(0, jumpHeight * 10, 0));
        }
    }
}
