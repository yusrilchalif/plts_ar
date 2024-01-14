using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    //public static SceneChanger instance;

    //private void Awake()
    //{
    //    if (instance == null)
    //    {
    //        instance = this;
    //    }
    //    else
    //    {
    //        Debug.LogWarning("Another SceneChanger instance found. Destroying this one.");
    //        Destroy(gameObject);
    //        return;
    //    }
    //}

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
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
