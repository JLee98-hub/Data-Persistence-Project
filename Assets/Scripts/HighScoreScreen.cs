using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HighScoreScreen : MonoBehaviour
{
    public TextMeshProUGUI highScoreDisplay;
    public string nameDisplay;
    public int highScoreNumber;

    // Start is called before the first frame update
    private void Awake()
    {
        nameDisplay = PlayerPrefs.GetString("highscoreName");
        highScoreNumber = PlayerPrefs.GetInt("highscore");
        highScoreDisplay.text = "High Score: " + nameDisplay + ": " + highScoreNumber;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
