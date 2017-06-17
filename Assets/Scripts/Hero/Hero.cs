using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    //public parameters which can be changed 
    public float speed = 1;

    public bool isGrounded = false; // jump
    public float MaxJumpTime = 2f;
    public float JumpSpeed = 2f;


    //private properties and components
    Rigidbody2D myBody = null;
    SpriteRenderer sr = null;
    Animator animator = null;

    bool JumpActive = false; //jump
    float JumpTime = 0f;

    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Awake()
    {

    }

    void FixedUpdate()
    {
        move();
        jump();
        animate();
        power();
    }

    //moves hero when keys are pressed
    void move()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        float value = Input.GetAxis("Horizontal");

        if (Mathf.Abs(value) > 0)
        {
            Vector2 vel = myBody.velocity;
            vel.x = value * speed;
            myBody.velocity = vel;
        }

        if (value < 0)
        {
            sr.flipX = true;
        }
        else if (value > 0)
        {
            sr.flipX = false;
        }
    }

    //jump when key "space" is down
    void jump()
    {
        Vector3 from = transform.position + Vector3.up * 0.3f;
        Vector3 to = transform.position + Vector3.down * 0.1f;
        int layer_id = 1 << LayerMask.NameToLayer("Ground");

        RaycastHit2D hit = Physics2D.Linecast(from, to, layer_id);
        if (hit)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            this.JumpActive = true;
        }
        if (this.JumpActive)
        {
            //Якщо кнопку ще тримають
            if (Input.GetButton("Jump"))
            {
                this.JumpTime += Time.deltaTime;
                if (this.JumpTime < this.MaxJumpTime)
                {
                    Vector2 vel = myBody.velocity;
                    vel.y = JumpSpeed * (1.0f - JumpTime / MaxJumpTime) + 0.7f;
                    myBody.velocity = vel;
                }
            }
            else
            {
                this.JumpActive = false;
                this.JumpTime = 0;
            }
        }
    }

    //change animation
    void animate()
    {

    }

    //activate superpowers
    void power()
    {

    }


}