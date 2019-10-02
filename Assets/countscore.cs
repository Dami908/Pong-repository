using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class countscore : MonoBehaviour
{
    public Text scoreboard;
    public GameObject ball;

    private int paddle_1_score = 0;
    private int paddle_2_score = 0;


    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 13f)
        {
            paddle_1_score++;
        }

        if (ball.transform.position.x <= -13f)
        {
            paddle_2_score++;
        }

        scoreboard.text = (paddle_1_score.ToString()) + "-" + (paddle_2_score.ToString());

        print(paddle_1_score + "-" + paddle_2_score);
        

    }
}
