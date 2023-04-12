using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCheck : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Wall")) 
        {
            DestroyBullet();
        }
    }

    void DestroyBullet() 
    {
        Destroy(gameObject);
    }
}