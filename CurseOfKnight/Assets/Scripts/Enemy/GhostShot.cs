using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostShot : MonoBehaviour
{
    public float speed;

    public Transform Player;
    private Vector2 target;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(Player.position.x, Player.position.y);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyProjectile();
    }
}
