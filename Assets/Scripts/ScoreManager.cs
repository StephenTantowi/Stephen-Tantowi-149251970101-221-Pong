using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int rightScore;
    public int leftScore;
    public int maxScore;
    public BallControl ball;
    public PadleControl paddleR;
    public PadleControl paddleL;

    public void addRightScore(int increment)
    {
        ball.ResetBall();
        paddleL.ResetSpeed();
        paddleR.ResetSpeed();
        paddleL.ResetLength();
        paddleR.ResetLength();
        rightScore += increment;
        if(rightScore >= maxScore)
        {
            gameOver();
        }
    }
    public void addLeftScore(int increment)
    {
        ball.ResetBall();
        paddleL.ResetSpeed();
        paddleR.ResetSpeed();
        paddleL.ResetLength();
        paddleR.ResetLength();
        leftScore += increment;
        if (leftScore >= maxScore)
        {
            gameOver();
        }
    }
    public void gameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
