using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    private int health = 100;
    static public int maxHealth;
    public TMP_Text hpBar;
    public Animator animator;
    public GameObject destroyEffect;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        maxHealth = health;
        hpBar.text = "" + health;
    }

    public void TakeHit(int damage)
    {
        health -= damage;
        hpBar.text = "" + health;

        if (health <= 0)
        {
            // сделай анимацию


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
