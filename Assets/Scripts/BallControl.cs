using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Vector2 speed;
    private Rigidbody2D rig;
    public Vector2 resetPosition;
    public bool left = false;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x,resetPosition.y,2);
        rig.velocity = speed;
    }
    public void ActivateSpeedUp(float magnitute)
    {
        rig.velocity *= magnitute;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("LeftPaddle"))
        {
            left = true;
        }
        else if(collision.gameObject.CompareTag("RightPaddle"))
        {
            left = false;
        }
    }
}
