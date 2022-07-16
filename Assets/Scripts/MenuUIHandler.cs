using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
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
        MainMenu.menu.playerName = MainMenu.menu.inputField.text;
    }
}
