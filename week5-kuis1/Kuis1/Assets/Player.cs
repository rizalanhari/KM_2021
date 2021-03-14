using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float jumpPower = 110;
    Rigidbody2D rb;
    Animator animator;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField] LayerMask groundLayer;
    const float groundCheckRadius = 0.2f;
    float horizontalValue;
    float runSpeedModifier = 2f;
    bool facingLeft = true;
    bool jump = false;
    [SerializeField] bool isGrounded = false;
    [SerializeField] bool isRunning = false;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalValue = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isRunning = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isRunning = false;
        }
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            jump = false;
        }
    }
    void FixedUpdate()
    {
        GroundCheck();
        Move(horizontalValue, jump);
    }

    void GroundCheck()
    {
        isGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius, groundLayer);
        if (colliders.Length > 0)
        {
            isGrounded = true;
        }
    }

    void Move(float dir, bool jumpFlag)
    {
        if (isGrounded && jumpFlag)
        {
            animator.SetTrigger("Jump");

            isGrounded = false;
            jumpFlag = false;
            rb.AddForce(new Vector2(0f, jumpPower));
        }

        float xVal = dir * Time.fixedDeltaTime * speed * 100;
        if (isRunning)
        {
            xVal *= runSpeedModifier;
        }
        Vector2 targetVelocity = new Vector2(xVal, rb.velocity.y);
        rb.velocity = targetVelocity;

        //fubah arah player
        if (facingLeft && dir > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            facingLeft = false;
        }
        else if (!facingLeft && dir < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            facingLeft = true;
        }
        animator.SetFloat("xVelocity", Mathf.Abs(rb.velocity.x));
    }

}
