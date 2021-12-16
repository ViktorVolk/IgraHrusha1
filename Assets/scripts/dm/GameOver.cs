using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public int allscore;
    public int money;

    private void Start()
    {
        allscore = PlayerPrefs.GetInt("ALLScore");
        score = PlayerPrefs.GetInt("Score");
        allscore = allscore + (score);
        PlayerPrefs.SetInt("ALLScore", allscore);
        scoreText.text = allscore.ToString();
        PlayerPrefs.SetInt("Score", 0);
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void GoToGame()
    {
        SceneManager.LoadScene(1);
    }
    
}
