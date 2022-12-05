using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    [SerializeField] GameObject ballRef;
    [SerializeField] Rigidbody2D rb;
    

    void Start()
    {
        SetRandomVelocity();
    }

    void FixedUpdate() 
    {
        CheckOutOfBounds();
    }

    void CheckOutOfBounds()
    {
        if (ballRef.transform.position.x > 10)
        {
            ResetBall();
        }

        if (ballRef.transform.position.x < -10)
        {
            ResetBall();
        }
    }

    void ResetBall()
    {
        ballRef.transform.position = new Vector2(0, Random.Range(-4f,4f));

        SetRandomVelocity();
        
    }

    void SetRandomVelocity()
    {
        rb.velocity = new Vector2(Random.Range(-8f,8f), Random.Range(-8f,8f));
        Debug.Log("X: " + rb.velocity.x);
        Debug.Log("Y: " + rb.velocity.y);

        //Removing slow balls
        if ( (rb.velocity.x < 1 && rb.velocity.x > -1) || (rb.velocity.y < 1 && rb.velocity.y > -1) )
        {
            Debug.Log("Reset");
            ResetBall();
        }
    }





}
