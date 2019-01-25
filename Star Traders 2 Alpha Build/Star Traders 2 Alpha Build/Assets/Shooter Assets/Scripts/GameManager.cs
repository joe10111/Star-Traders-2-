using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int currentLives = 3;

    public float respawnTime = 2f;

    public int currentScore;

    private int highScore = 500;

    private void Awake()
    {
        instance = this;
    }

     void Start()
    {
        UIManager.instance.livesText.text = "x " + currentLives;

        UIManager.instance.scoreText.text = "Score: " + currentScore;


        highScore = PlayerPrefs.GetInt("HighScore");
        UIManager.instance.highScoreText.text = "HI-Score: " + highScore;
    }

     void Update()
    {
        
    }
    public void KillPlayer()
    {
        currentLives--;
        UIManager.instance.livesText.text = "x " + currentLives;
        if (currentLives > 0)
        {
            //Respawn code
            StartCoroutine(RespawnCo());
        }else
        {
            //GameOver
            UIManager.instance.gameOverScreen.SetActive(true);
            WaveManager.instance.canSpawnWaves = false;
        }
    }


    public IEnumerator RespawnCo()
    {
        yield return new WaitForSeconds(respawnTime);
        Health.instance.Respawn();

        WaveManager.instance.continueSpawning();
    }
    public void AddScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        UIManager.instance.scoreText.text = "Score: " + currentScore;

        if(currentScore > highScore)
        {
            highScore = currentScore;
            UIManager.instance.highScoreText.text = "HI-Score: " + highScore;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    public IEnumerator EndLevelCo()
    {
        UIManager.instance.levelEndScreen.SetActive(true);

       
            yield return new WaitForSeconds(.5f);
        
    }
}
