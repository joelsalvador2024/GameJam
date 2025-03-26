using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isGrounded;
    public float speed;
    private float move;
    public float jump;
    private Animator playerAnimator;
    private SpriteRenderer sprite;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if(move != 0)
        {
            playerAnimator.SetBool("IsRunning", true);
        }
        else
        {
            playerAnimator.SetBool("IsRunning", false);
        }

        if(move < 0)
        {
            sprite.flipX = true;
        }
        else
        {
            sprite.flipX = false;
        }

        if (Input.GetKeyDown("x"))
        {
            playerAnimator.Play("Parry", 0 , 0.25f);
        }
        if (!isGrounded)
        {
            playerAnimator.SetBool("IsJumping", true);
        }
        if (isGrounded)
        {
            playerAnimator.SetBool("IsJumping", false);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
}