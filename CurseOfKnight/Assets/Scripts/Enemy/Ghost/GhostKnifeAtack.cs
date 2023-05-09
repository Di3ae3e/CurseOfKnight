using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class GhostKnifeAtack : MonoBehaviour
{
    public float speed;

    private Transform player;
    private Vector2 target;

    public SpriteRenderer projectileRender;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y+1);
        projectileRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

            float angle = Mathf.Atan2(-target.x, target.y) * Mathf.Rad2Deg + 90;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            if (transform.position.x > player.position.x)
            {
                projectileRender.flipY = true;
            }
            else
            {
                projectileRender.flipY = false;
            }


            // Vector3 relativePosition = player.position - transform.position;
            if (transform.position.x == target.x && transform.position.y == target.y)
                Destroy(gameObject);
        }
        else
            Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}
