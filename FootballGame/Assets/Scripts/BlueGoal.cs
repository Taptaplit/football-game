using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlueGoal : MonoBehaviour
{
    public TMP_Text redScoreText;
    public GameObject redPlayer;
    public GameObject bluePlayer;
    public GameObject Ball;

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
            redScoreText.text = (int.Parse(redScoreText.text) + 1).ToString();
            redPlayer.transform.position = new Vector3(-3.26f, 3.01f, 0f);
            bluePlayer.transform.position = new Vector3(3.43f, 3.01f, 0f);
            Ball.transform.position = new Vector3(0f, 2.03f, 0f);
        }
    }
}
