using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public static MainMenu menu;

    public TMP_InputField inputField;
    public string playerName;


    private void Awake()
    {
        if (menu != null)
        {
            Destroy(gameObject);
            return;
        }

        menu = this;
        DontDestroyOnLoad(gameObject);
    }
    
}
