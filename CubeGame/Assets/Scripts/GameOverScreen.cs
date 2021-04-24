using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public Text timeText;

    public void Setup(int score, float timeStamp)
    {
        gameObject.SetActive(true);
        pointsText.text = "SCORE : " + score.ToString();
        timeText.text = "       Time : " + timeStamp.ToString("0.00");

    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenuFinal");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
