using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotate : MonoBehaviour
{
    public float offset;
    public SpriteRenderer spriteRenderer;

    void Update()
    {
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        Vector3 LocalScale = Vector3.one;

        if(rotateZ > 90 || rotateZ < -90)
        {
            LocalScale.y = -1f;
            spriteRenderer.flipX = true;
        } 
        else
        {
            LocalScale.y = +1f;
            spriteRenderer.flipX = false;
        }
        transform.localScale = LocalScale;
    }
    
}