using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAtack : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;

    private float timeBtwShots;
    public float startBtwShots;


    public GameObject projectile;
    public Transform Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        timeBtwShots = startBtwShots;
    }

    private void Update()
    {
        if(Vector2.Distance(transform.position, Player.position) > stoppingDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, Player.position) < stoppingDistance && Vector2.Distance(transform.position, Player.position) > retreatDistance)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position, Player.position) < retreatDistance) 
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.position, -speed * Time.deltaTime);
        }

        if(timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
