using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject GameOver;
    public float Jumpforce;
    public Rigidbody2D rb;
    public Text scoreText;
    public int Score = 0;
    public Text HighScoreText;
    public int HighScore = 0;
    //public GameObject Ingame; 
  
    // Start is called before the first frame update
    void Start()
    {        
        rb =  GetComponent<Rigidbody2D>();
        scoreText.text = Score.ToString();
        HighScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * Jumpforce;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * Jumpforce;
        }
        scoreText.text = Score.ToString();
        HighScoreText.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    public void UpdateScore()
    {
        Score++;
        scoreText.text = Score.ToString();

    }

    public void Highscore()
    {
        if(Score>PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", Score);
            HighScoreText.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        }
            
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Scoring")
        {
            Score += 1;
            Highscore();
        }
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
            GameOver.SetActive(true);
           //Ingame.SetActive(false);
        }
    }
}
