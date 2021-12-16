using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigControl : MonoBehaviour
{
    public float JumpPower;
    private Rigidbody2D rb;
    private bool IsGrounded;
    public Transform feetPos;
    public float CheckRadius;
    public LayerMask whatIsGround;
    public float speed;
    private float moveInput;
    private bool FaceRight = true;
    public Joystick joystick;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveInput = joystick.Horizontal;
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (FaceRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (FaceRight == true && moveInput < 0)
        {
            Flip();
        }
        if (moveInput == 0)
        {
            anim.SetBool("isGo", false);
        }
        else
        {
            anim.SetBool("isGo", true);
        } 
    }
    private void Update()
    {
        float verticalMove = joystick.Vertical;
        IsGrounded = Physics2D.OverlapCircle(feetPos.position, CheckRadius, whatIsGround);
        if (IsGrounded == true && verticalMove >= .5f)
        {
            rb.velocity = Vector2.up * JumpPower;
            anim.SetTrigger("off");
        }
        if (IsGrounded == true)
        {
            anim.SetBool("isJump", false);
        }
        else
        {
            anim.SetBool("isJump", true);
        } 
    }

    void Flip()
    {
        FaceRight = !FaceRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

        if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        } 
    }
}
