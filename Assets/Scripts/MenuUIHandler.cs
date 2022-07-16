using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void HighScoreScreen()
    {
        SceneManager.LoadScene(2);
    }

    public void SetPlayerName()
    {
        MainMenu.menu.playerName = inputField.text;
    }
}
