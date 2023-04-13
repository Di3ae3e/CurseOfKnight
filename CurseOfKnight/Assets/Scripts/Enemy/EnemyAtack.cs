using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    public float speed = 1f;
    public Transform target;

    public int collisionDamage = 10;
    public string collisionTag;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void MoveToPlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
    
    void Update()
    {
        MoveToPlayer();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == collisionTag)
        {
            PlayerHealth health = other.gameObject.GetComponent<PlayerHealth>();
            health.TakeHit(collisionDamage);
            speed = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == collisionTag)
        {
            speed = 1;
        }
    }
}