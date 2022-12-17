using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RedGoal : MonoBehaviour
{
    public TMP_Text blueScoreText;
    public GameObject redPlayer;
    public GameObject bluePlayer;
    public GameObject Ball;
    public Rigidbody rigidBall;
    public Rigidbody redBall;
    public Rigidbody blueBall;
    
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
        if (collision.collider.name == "Ball")
        {
            blueScoreText.text = (int.Parse(blueScoreText.text) + 1).ToString();
            redPlayer.transform.position = new Vector3(-3.43f, 17.83f, -20.1f);
            redPlayer.transform.Rotate(0, 0, 0);
            redBall.velocity = Vector3.zero;
            bluePlayer.transform.position = new Vector3(3.43f, 17.83f, -20.1f);
            bluePlayer.transform.Rotate(0, 0, 0);
            blueBall.velocity = Vector3.zero;
            Ball.transform.position = new Vector3(0f, 16.85f, -20.1f);
            Ball.transform.Rotate(0, 0, 0);
            rigidBall.velocity = Vector3.zero;
        }
    }
}
