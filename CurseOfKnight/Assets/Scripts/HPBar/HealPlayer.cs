using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPlayer : MonoBehaviour
{
    public int collisonHeal = 10;
    public string collisionTag;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();
            health.SetHealth(collisonHeal);
            Destroy(gameObject);
        }
    }
}
