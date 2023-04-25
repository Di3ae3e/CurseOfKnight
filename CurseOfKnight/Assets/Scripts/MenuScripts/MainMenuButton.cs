using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    int numScene = RandomNumberGenerator.GetInt32(2);
    public void LoadPlayScenes()
    {
        SceneManager.LoadScene(numScene);
    }
    public void LoadOtherScenes(int numOtherScene)
    {
        SceneManager.LoadScene(numOtherScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
