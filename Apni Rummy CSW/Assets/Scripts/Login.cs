using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public string levelToLoad;
    public float delay = 2f;
    public void LoadLevel()
    {
        Invoke("LoadLevel", delay);
    }

    public void LoadScene(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
