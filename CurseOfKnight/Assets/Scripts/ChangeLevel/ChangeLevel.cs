using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    [HideInInspector] static public Animator anim;
    public int levelToLoad;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    static public void FadeToLevel(ref Animator anim)
    {
        anim.SetTrigger("fade");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
