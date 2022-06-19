using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleLength : MonoBehaviour
{
    public PadleControl paddleLeft;
    public PadleControl paddleRight;
    public PowerUpManager manager;
    private float timer = 5;
    public BallControl ball;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            manager.RemovePowerUp(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            if(ball.left == true)
            {
                paddleLeft.ActiveLengthUp();
            }
            else if(ball.left == false)
            {
                paddleRight.ActiveLengthUp();
            }

            manager.RemovePowerUp(gameObject);
        }
    }
}
