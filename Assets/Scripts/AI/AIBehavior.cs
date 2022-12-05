using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIBehavior : MonoBehaviour
{
    [SerializeField] float moveSpeed = 225;

    bool dirUp = true;

    float maxY = 4;
    float minY = -4;

    void Update() 
    {
        MoveAIPaddle();
    }

    void MoveAIPaddle()
    {
        if (dirUp)
        {
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }

        if (transform.position.y >= maxY)
        {
            dirUp = false;
        }
        
        if (transform.position.y <= minY)
        {
            dirUp = true;
        }
    }


}


