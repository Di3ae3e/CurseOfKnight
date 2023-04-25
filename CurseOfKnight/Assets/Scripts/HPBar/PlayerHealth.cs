using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    static public int maxHealth;
    public TMP_Text hpBar;

    private void Awake()
    {
        maxHealth = health;
        hpBar.text = "" + health;
    }

    public void TakeHit(int damage)
    {
        health -= damage;
        hpBar.text = "" + health;

        if (health <= 0)
        {
            Destroy(gameObject);
            Destroy(hpBar);
        }
    }

    public void SetHealth(int bonusHealth)
    {
        health += bonusHealth;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        hpBar.text = "" + health;
    }
}
