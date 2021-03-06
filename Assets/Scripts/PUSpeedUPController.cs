using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUPController : MonoBehaviour
{
    public Collider2D ball;
    public float magnitute;
    public PowerUpManager manager;
    private float timer = 5; 


    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            manager.RemovePowerUp(gameObject);
        }    
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            ball.GetComponent<BallControl>().ActivateSpeedUp(magnitute);
            manager.RemovePowerUp(gameObject);
        }
    }

}
