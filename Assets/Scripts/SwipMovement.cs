using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SwipMovement : MonoBehaviour
{
    private float deltaX;
    private Rigidbody2D rb;
    private Vector2 lastPosition;
    private Vector2 dragVelocity;
  

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchposition = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    deltaX = touchposition.x - transform.position.x;
                    lastPosition = touchposition;
                    rb.velocity = Vector2.zero;
                    break;

                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(touchposition.x - deltaX ,transform.position.y));
                    dragVelocity = (touchposition - lastPosition)/Time.deltaTime;
                    lastPosition = touchposition;
                    break;

                case TouchPhase.Ended:
                    rb.velocity = new Vector2(dragVelocity.x , 0);
                    break;
            }

        }


        
    }
}
