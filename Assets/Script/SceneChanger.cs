using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static SceneChanger instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void GoToARScene()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void QuitApps()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }
}
