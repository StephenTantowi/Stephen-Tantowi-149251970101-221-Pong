using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleLength : MonoBehaviour
{
    public Collider2D ball;
    public PadleControl paddleLeft;
    public PadleControl paddleRight;
    public PowerUpManager manager;
    private float timer = 5;

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
            paddleLeft.ActiveLengthUp();
            paddleRight.ActiveLengthUp();
            manager.RemovePowerUp(gameObject);
        }
    }
}
