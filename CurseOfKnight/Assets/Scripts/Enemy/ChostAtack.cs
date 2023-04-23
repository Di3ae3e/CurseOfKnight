using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ChostAtack : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;

    public SpriteRenderer projectileRender;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
        projectileRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        Vector3 relativePosition = player.position - transform.position;
        
        if(transform.position.x ==  target.x && transform.position.y == target.y)
        {
            Destroy(gameObject);
        }

        if(transform.position.x > target.x) { projectileRender.flipX = true; }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
