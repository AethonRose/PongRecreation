using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerPaddleMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float moveSpeed = 225;

    float verticalInput;

    void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate() 
    {
        MovePlayerPaddle(moveSpeed);
    }

    void MovePlayerPaddle(float moveSpeed)
    {
        rb.velocity = new Vector2(rb.velocity.x,  verticalInput * moveSpeed * Time.deltaTime); 
    }

}

