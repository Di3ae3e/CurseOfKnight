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

    private UnityEngine.Object explosion;

    public GameObject deathScreen;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        maxHealth = health;
        hpBar.text = "" + health;

        explosion = Resources.Load("Explosion");
    }

    public void TakeHit(int damage)
    {
        health -= damage;
        hpBar.text = "" + health;

        if (health <= 0)
        {
            GameObject explosionRef = (GameObject)Instantiate(explosion);
            explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            deathScreen.SetActive(true);
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
