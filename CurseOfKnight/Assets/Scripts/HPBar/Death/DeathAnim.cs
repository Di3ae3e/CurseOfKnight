using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnim : MonoBehaviour
{
    [HideInInspector] static public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    static public void Death(ref Animator anim)
    {
        anim.SetTrigger("dearh");
    }
}
