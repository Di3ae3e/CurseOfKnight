using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHpScripts : MonoBehaviour
{
    public int quantityHeatlhPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth.maxHealth += quantityHeatlhPoint;
            Destroy(gameObject);
        }
    }
}
