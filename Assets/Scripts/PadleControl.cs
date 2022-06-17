using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadleControl : MonoBehaviour
{
    public Vector2 movement;
    public int speed;
    private int initSpeed;
    public KeyCode upkey;
    public KeyCode downkey;
    private Rigidbody2D rig;
    private Vector3 scale;
    private float timerLength = 5;
    private float timerSpeed = 5;
    private bool paddleLengthActive = false;
    private bool paddleSpeedActive = false;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        scale = transform.localScale;
        initSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(GetInput());
        if(paddleLengthActive == true)
        {
            timerLength -= Time.deltaTime;
            if (timerLength <= 0)
            {
                ResetLength();
                paddleLengthActive = false;
                timerLength = 5;
            }
        }
        
        if(paddleSpeedActive == true)
        {
            timerSpeed -= Time.deltaTime;
            if(timerSpeed <= 0)
            {
                ResetSpeed();
                paddleSpeedActive = false;
                timerSpeed = 5;
            }
        }
    }
    private Vector2 GetInput()
    {
        if (Input.GetKey(upkey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downkey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Kecepata Paddle : " + movement);
        rig.velocity = movement;
    }

    public void ActiveLengthUp()
    {
        if(paddleLengthActive == false)
        {
            transform.localScale = new Vector3(scale.x, scale.y * 2, scale.z);
            paddleLengthActive = true;
        }
        
    }

    public void ActiveSpeedUp()
    {
        if(paddleSpeedActive == false)
        {
            speed *= 2;
            paddleSpeedActive = true;
        }      
    }

    public void ResetLength()
    {
        transform.localScale = scale;
    }
    public void ResetSpeed()
    {
        speed = initSpeed;
    }    
}
