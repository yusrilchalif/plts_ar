using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] Button startButton, exitButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(GoTosceneAR);
        exitButton.onClick.AddListener(QuitButton);
    }

    public void GoTosceneAR()
    {
        SceneChanger.instance.GoToARScene();
    }

    public void QuitButton()
    {
        SceneChanger.instance.QuitApps();
    }
}
