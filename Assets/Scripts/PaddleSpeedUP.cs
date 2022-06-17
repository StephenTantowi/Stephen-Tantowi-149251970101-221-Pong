using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleSpeedUP : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    private float timer = 5;
    public PadleControl paddleLeft;
    public PadleControl paddleRight;

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
        if (collision == ball)
        {
            paddleLeft.ActiveSpeedUp();
            paddleRight.ActiveSpeedUp();
            manager.RemovePowerUp(gameObject);
        }
    }
}
