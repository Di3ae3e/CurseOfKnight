using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectileTransform;

    public float StartTimeFire;
    private float TimeFire;

    void Start()
    {
        TimeFire = StartTimeFire;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            if(TimeFire <= 0)
            {
                Instantiate(projectile, projectileTransform.position, transform.rotation);
                TimeFire = StartTimeFire;
            } 
            else
            {
                TimeFire -=Time.deltaTime;
            }
        }
    }
}