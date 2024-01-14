using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoHome : MonoBehaviour
{
    [SerializeField] Button backMenu;

    // Start is called before the first frame update
    void Start()
    {
        backMenu.onClick.AddListener(BackToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu()
    {
        print("Button clicked");
        SceneChanger.instance.GoToMainMenu();
    }
}
