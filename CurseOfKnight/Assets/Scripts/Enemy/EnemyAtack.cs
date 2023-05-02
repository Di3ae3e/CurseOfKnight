using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    public float speed = 1f;
    public Transform target;
    public Vector2 startPosition;
    public SpriteRenderer enemySpriteRender;
    public Animator animator;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemySpriteRender = GetComponent<SpriteRenderer>();
    }

    void MoveForPlayer()
    {
        if(target == null)
        {
            // transform.position = Vector2.MoveTowards(transform.position, startPosition, speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            if(transform.position.x > target.position.x)
            {
                enemySpriteRender.flipX = true;
            }
            else
            {
                enemySpriteRender.flipX = false;
            }
        }
    }
    
    void Update()
    {
        MoveForPlayer();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            speed = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            speed = 1;
        }
    }
}
