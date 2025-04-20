using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed = 5f;

    Rigidbody2D rb;

    private float moveInput;

    private float lastDirection;

    private float minX = -2.21f;
    private float maxX = 2.21f;




    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        moveInput = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(moveInput* MoveSpeed , rb.velocity.y);


        // If input is not zero, update the last direction
        if (moveInput != 0)
        {
            lastDirection = moveInput > 0 ? 1f : -1f;
        }

        // Apply velocity using last known direction
        rb.velocity = new Vector2(lastDirection * MoveSpeed, rb.velocity.y);

        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
    }
}
