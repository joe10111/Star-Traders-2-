using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int currentLives = 3;

    public float respawnTime = 2f;

    public int currentScore;

    private int highScore = 500;

    public bool levelEnding;

    private int levelScore;

    public float waitForLevelEnd = 5f;

    public string nextLevel;

    public string Level1 = "Level1";

    private void Awake()
    {
        instance = this;
    }

     void Start()
    {
       
        Scene currentScence = SceneManager.GetActiveScene();
        string scenceName = currentScence.name;
        PlayerPrefs.SetInt("CurrentLives", 3);
        if (scenceName == Level1)
        {
            Debug.Log(currentLives);
         // PlayerPrefs.DeleteKey("CurrentLives", currentLives);
            currentLives = 3;
            PlayerPrefs.SetInt("CurrentLives", 3);
            PlayerPrefs.SetInt("CurrentScore", 0);
        }
         currentLives = PlayerPrefs.GetInt("CurrentLives");
         UIManager.instance.livesText.text = "X " + currentLives;
       


        highScore = PlayerPrefs.GetInt("HighSCORE");
        UIManager.instance.highScoreText.text = "HI-SCORE: " + highScore;

        currentScore = PlayerPrefs.GetInt("CurrentScore");
        UIManager.instance.scoreText.text = "SCORE: " + currentScore;
    }

     void Update()
    {

        Scene currentScence = SceneManager.GetActiveScene();
        string scenceName = currentScence.name;
        if (scenceName == Level1)
        {
            print("I hate Mike");
        }
            if (levelEnding)
        {
            PlayerController.instance.transform.position += new Vector3(PlayerController.instance.boostSpeed * Time.deltaTime, 0f, 0f);
        }
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

            PlayerPrefs.SetInt("HighSCORE", highScore);
            currentScore = 0;
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
        levelScore += scoreToAdd;
        UIManager.instance.scoreText.text = "SCORE: " + currentScore;

        if(currentScore > highScore)
        {
            highScore = currentScore;
            UIManager.instance.highScoreText.text = "HI-SCORE: " + highScore;
        }
    }

    public IEnumerator EndLevelCo()
    {
        UIManager.instance.levelEndScreen.SetActive(true);
        PlayerController.instance.stopMovement = true;
        levelEnding = true;

        yield return new WaitForSeconds(.5f);

        UIManager.instance.endLevelScore.text = "LEVEL SCORE: " + levelScore;
        UIManager.instance.endLevelScore.gameObject.SetActive(true);

      yield return new WaitForSeconds(.5f);

        PlayerPrefs.SetInt("CurrentScore", currentScore);
        UIManager.instance.endCurrentScore.text = "TOTAL SCORE: " + currentScore;
        UIManager.instance.endCurrentScore.gameObject.SetActive(true);

        if(currentScore == highScore)
        {
            yield return new WaitForSeconds(.5f);
            UIManager.instance.highscoreNotice.SetActive(true);
        }

        PlayerPrefs.SetInt("HighSCORE", highScore);
        PlayerPrefs.SetInt("CurrentLives", currentLives);

        yield return new WaitForSeconds(waitForLevelEnd);

        SceneManager.LoadScene(nextLevel);

    }
}
