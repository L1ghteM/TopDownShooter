using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    bool gameOver = false;
    int score = 0;
    public Text scoreText;
    public GameObject gameOverPanel;

    private void Awake()
    {
        gm = this;
    }



    public void GameOver()
    {
        gameOver = true;
        GameObject.Find("SpawnManager").GetComponent<SpawnManager>().StopSpawning();
        gameOverPanel.SetActive(true);
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = score.ToString();
            print(score);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
