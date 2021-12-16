using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public int score;
    public int allscore;
    public Text scoreText;
    public GameObject BackSound;
    public GameObject Butt;

    public void StartGame()
    {
        Instantiate(Butt, transform.position, Quaternion.identity);
        SceneManager.LoadScene(1);
    }
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(BackSound, transform.position, Quaternion.identity);
        allscore = PlayerPrefs.GetInt("ALLScore");
        score = PlayerPrefs.GetInt("Score");
        PlayerPrefs.SetInt("ALLScore", allscore);
        scoreText.text = allscore.ToString();
        PlayerPrefs.SetInt("Score", 0);
    }

    public void Shop()
    {
        Instantiate(Butt, transform.position, Quaternion.identity);
        SceneManager.LoadScene(3);
    }

    // Update is called once per frame
    void Update()
    {
        allscore = PlayerPrefs.GetInt("ALLScore");
        scoreText.text = allscore.ToString();
    }

    public void Pestart()
    {
        score = score * 0;
        PlayerPrefs.SetInt("ALLScore", score);
    }

    public void GoRules()
    {
        SceneManager.LoadScene(4);
    }
}
