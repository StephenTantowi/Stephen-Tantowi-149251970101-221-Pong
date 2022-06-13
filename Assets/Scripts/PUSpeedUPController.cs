using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUPController : MonoBehaviour
{
    public Collider2D ball;
    public float magnitute;
    public PowerUpManager manager;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            ball.GetComponent<BallControl>().ActivateSpeedUp(magnitute);
            manager.RemovePowerUp(gameObject);
        }
    }

}
