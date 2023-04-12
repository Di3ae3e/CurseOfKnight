using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderHit : MonoBehaviour
{
    public int damage;
    public string collisionTag;
    GameObject Player;
    public int Health;

    void OnCollisionEnter2D(Collision2D enemy)
{
    if (enemy.gameObject.tag == "Enemy")
        StartCoroutine(ToDamage());
}

void OnCollisionExit2D(Collision2D enemy)
{
    if (enemy.gameObject.tag == "Enemy")
        StopAllCoroutines();
}

private IEnumerator ToDamage()
{
    //Отнимаем 1ед здоровья пока здоровье есть или пока корутина не будет остановлена
    while (Health > 0)
    {
        Health -= 1;
        yield return new WaitForSeconds(1.0f);
    }
}
}
