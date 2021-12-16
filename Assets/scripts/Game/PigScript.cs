using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PigScript : MonoBehaviour
{
    public int score;
    public GameObject EatSound;
    public GameObject KillSound;
    [SerializeField] Text scoreText;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            Instantiate(EatSound, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            score++;
        }

        if (other.gameObject.tag == "kill")
        {
            Instantiate(KillSound, transform.position, Quaternion.identity);
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene(2);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
    
}
