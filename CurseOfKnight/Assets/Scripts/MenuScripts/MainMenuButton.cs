using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    public void LoadScenes(int numScene)
    {
        SceneManager.LoadScene(numScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
