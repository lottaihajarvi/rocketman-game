using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator playerController;
    private bool isRunning = false;
    private bool facingRight;
    private bool isJumping = false;
    public float moveSpd = 1f;
    public float jumpSpd;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerController = GetComponent<Animator>();
    }

    void Update()
    {
        if (isRunning && facingRight && !isJumping)
        {
            rb.velocity = new Vector2(moveSpd, rb.velocity.y);

        } else if (isRunning && !facingRight && !isJumping)
        {
            rb.velocity = new Vector2(-moveSpd, rb.velocity.y);
        }
    }

    public void playerRunRight(bool value)
    {
        playerController.SetBool("isRunning", value);
        transform.localScale = new Vector2(5f, transform.localScale.y);

        facingRight = true;
        isRunning = value;
    }

    public void playerRunLeft(bool value)
    {
        playerController.SetBool("isRunning", value);
        transform.localScale = new Vector2(-5f, transform.localScale.y);
        
        facingRight = false;
        isRunning = value;
    }

    public void playerJump()
    {
        if (!isJumping)
        {
            isJumping = true;

            //playerController.SetTrigger("isJumping");
            rb.velocity = new Vector2(rb.velocity.x, jumpSpd);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Platform"))
        {
            isJumping = false;
        }
    }

}
