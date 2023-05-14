using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour
{
    [HideInInspector] static public float lifeTime;
    private float startLifeTime = 2f;

    private void Start()
    {
        lifeTime = startLifeTime;
    }

    private void Update()
    {
        if(lifeTime <= 0)
        {
            Destroy(this.gameObject);
            lifeTime = startLifeTime;
        }
        else
        {
            lifeTime -= Time.deltaTime;
        }
    }
}
