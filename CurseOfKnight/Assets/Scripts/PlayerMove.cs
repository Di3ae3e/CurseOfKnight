using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    public float forcePush = 20f;
    public float timeResetForPush = 5f;

    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Walk();
        if (Input.GetKeyDown(KeyCode.F))
            Push();
        animator.SetFloat("Speed", Mathf.Abs(moveVector.y));
    }

    void Walk()
    {
        moveVector.x = Input.GetAxis("Vertical");
        moveVector.y = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        rb.velocity = new Vector2(moveVector.y * speed, rb.velocity.x);
    }

    void Push()
    {
        rb.velocity = new Vector2(0, 0);
        if (moveVector.y > 0 && moveVector.x == 0)
            rb.AddForce(Vector2.right * forcePush);
        else if (moveVector.y < 0 && moveVector.x == 0)
            rb.AddForce(Vector2.left * forcePush);
        else if (moveVector.y == 0 && moveVector.x > 0)
            rb.AddForce(Vector2.up * forcePush);
        else if (moveVector.y == 0 && moveVector.x < 0)
            rb.AddForce(Vector2.down * forcePush);
    }
}
