using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
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
        if (Input.GetKey("right")) {
            float horizontal = Input.GetAxisRaw("Horizontal");
            moveDir.x = horizontal * speed;
            float y = Input.GetAxisRaw("Vertical");
            moveDir.y = y;
            controller.Move(moveDir * Time.deltaTime);
        }
        if (Input.GetKey("left")) {
            float horizontal = Input.GetAxisRaw("Horizontal");
            moveDir.x = horizontal * speed;
            float y = Input.GetAxisRaw("Vertical");
            print(y);
            moveDir.y = y;
            controller.Move(moveDir * Time.deltaTime);
        }
        if (Input.GetKey("up")) {
            rb.AddForce(new Vector3(0, jumpHeight * 10, 0));
        }
    }
}
