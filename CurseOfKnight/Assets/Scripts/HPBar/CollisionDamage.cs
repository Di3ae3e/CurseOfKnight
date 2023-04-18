using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int collisionDamage;
    public string collisionTag;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == collisionTag)
        {
            PlayerHealth health = other.gameObject.GetComponent<PlayerHealth>();
            health.TakeHit(collisionDamage);
        }
    }
}
