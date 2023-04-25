using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int collisionDamage;
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == collisionTag)
        {
            PlayerHealth health = collision.gameObject.GetComponent<PlayerHealth>();
            health.TakeHit(collisionDamage);
        }
    }
}
