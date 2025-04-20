using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    private Transform target;

    public Transform PointB;

    private float Speed = 3f;

    Rigidbody2D rb;
    private void Awake()
    {
        target = PointB;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        Vector3 currentPosition = transform.position;
        Vector3 targetPosition = new Vector3(target.position.x, currentPosition.y, currentPosition.z);

        transform.position = Vector3.MoveTowards(currentPosition, targetPosition, Speed * Time.deltaTime);
    


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Destorypoint")
        {
            Destroy(gameObject);
        }
    }



}
