using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    Rigidbody2D rb;
    private bool turnAround;
    public float moveSpd;
    public Transform checkLedge;
    public LayerMask cloudLayer;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }

    void FixedUpdate()
    {
        turnAround = !Physics2D.OverlapCircle(checkLedge.position, 0.1f, cloudLayer);
    }

    void Move()
    {
        if (turnAround)
        {
            Turn();
        }

        rb.velocity = new Vector2(moveSpd * Time.fixedDeltaTime, rb.velocity.y);
    }

    void Turn()
    {
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        moveSpd *= -1;
    }
}
