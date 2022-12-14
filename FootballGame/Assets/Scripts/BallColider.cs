using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColider : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player-1" || collision.collider.name == "Player-2")
        {
            foreach (ContactPoint contact in collision.contacts)
            {
                if (contact.point[1] > 0.6) {
                    rb.AddForce(new Vector3(0, 50, 0));
                }
            }
        }
    }
}
