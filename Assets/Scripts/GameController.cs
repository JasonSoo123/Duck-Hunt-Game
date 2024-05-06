using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    
    public AudioSource LoseLife, HitBird, LifeUp;
    
    public int score, lives;
    public Text scoreText, livesText, centerText, timeText;
    public float timer;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        
    }
    void Start()
    {
        score = 0;
        lives = 3;
        Time.timeScale = 1;
        scoreText.text = "Score: " + score;
        livesText.text = "Lives: " + lives;
        centerText.enabled = false;
    }
    void LateUpdate()
    {
        timer -= Time.deltaTime;
        timeText.text = "Time: " + Mathf.Round(timer) + "s";

        if (timer <= 0)
        {
            Time.timeScale = 0;
            centerText.enabled = true;

            if (SceneManager.GetActiveScene().name.Equals("Level1"))
            {
                centerText.text = "You survived with a score of " + score + ". Amazing!\n Press SPACE to go to the next level";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene("Level2");
                }
            }
            if (SceneManager.GetActiveScene().name.Equals("Level2"))
            {
                centerText.text = "You survived with a score of " + score + ". Amazing!\nPress SPACE to return back to main menu";
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene("Main Menu");
                }
            }
        }
        if (lives <= 0)
        {
            centerText.enabled = true;
            Time.timeScale = 0;
            centerText.text = "You lose!\nPress SPACE to go back to the main menu";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("Main Menu");
            }
            
     
        }
    }
    public void UpdateScore()
    {
        HitBird.Play();
        score += 100;
        scoreText.text = "Score: " + score;
    }
    public void DecreaseLives()
    {
        /*LoseLife.Play();*/
        lives -= 1;
        livesText.text = "Lives: " + lives;
    }
    public void IncreaseLives()
    {
        /*LifeUp.Play();*/
        lives ++;
        livesText.text = "Lives: " + lives;
       
    }
   
}
