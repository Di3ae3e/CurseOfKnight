 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnemy : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public SpriteRenderer enemySpriteRender;

    public float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    public Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemySpriteRender = GetComponent<SpriteRenderer>();
        timeBtwShots = startTimeBtwShots;
    }

    private void Update()
    {
        if(player.position == null)
        {
            transform.position = this.transform.position;
        }
        else
        {
            // Движение призрака
            if (Vector2.Distance(transform.position, player.position) > stoppingDistance)
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance)
                transform.position = this.transform.position;
            else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
                transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);

            if (transform.position.x > player.position.x)
                enemySpriteRender.flipX = true;
            else
                enemySpriteRender.flipX = false;
        }

        // Стрельба по рыцарю
        if(timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
