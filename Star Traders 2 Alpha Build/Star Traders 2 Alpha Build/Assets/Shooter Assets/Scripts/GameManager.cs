using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public int levelNumber;

    public Text stageText;

    private AudioSource source;
    public AudioClip coinSound;
    public int amountOfCredits;

  


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
     
       

        source = GetComponent<AudioSource>();

        Scene currentScence = SceneManager.GetActiveScene();
        string scenceName = currentScence.name;
        if (scenceName == "Main Menu")
        {
            highScore = PlayerPrefs.GetInt("HighSCORE");
            UIManager.instance.highScoreText.text = "HI-SCORE: " + highScore;
        }
        if (scenceName == Level1)
        {
            print("Level1 Loaded");
            Debug.Log(currentLives);
            // PlayerPrefs.DeleteKey("CurrentLives", currentLives);
            currentLives = 3;
            PlayerPrefs.SetInt("CurrentLives", 3);
            PlayerPrefs.SetInt("CurrentScore", 0);
            PlayerPrefs.SetFloat("UpFireRate", .6f);
            PlayerPrefs.SetFloat("SpeedUp", 7);
            PlayerPrefs.SetInt("LevelNumber", 1);
        }


        levelNumber = PlayerPrefs.GetInt("LevelNumber");
        //upgrades
        //FireRate
        PlayerController.instance.timeBetweenShots = PlayerPrefs.GetFloat("UpFireRate");
        //Health
        Health.instance.currentHealth = Health.instance.maxHealth;
        UIManager.instance.healthBar.maxValue = Health.instance.maxHealth;
        UIManager.instance.healthBar.value = Health.instance.currentHealth;
        print(Health.instance.maxHealth);
        //Speed
        PlayerController.instance.moveSpeed = PlayerPrefs.GetFloat("SpeedUp");

        //upgrades

        currentLives = PlayerPrefs.GetInt("CurrentLives");
        UIManager.instance.livesText.text = "X " + currentLives;




        highScore = PlayerPrefs.GetInt("HighSCORE");
        UIManager.instance.highScoreText.text = "HI-SCORE: " + highScore;

        currentScore = PlayerPrefs.GetInt("CurrentScore");
        UIManager.instance.scoreText.text = "SCORE: " + currentScore;

    }

    void Update()
    {
        
        if (levelNumber == 3)
        {
           
            stageText.text = "STAGE THREE";
           
        }
        if (levelNumber == 4)
        {
           
            stageText.text = "STAGE FOUR";
        }
        
        if (levelNumber == 5)
        {
            WaveManager.instance.esay = false;
            WaveManager.instance.medium = true;
            stageText.text = "STAGE FIVE";
            
        }
        if (levelNumber == 6)
        {
            WaveManager.instance.esay = false;
            WaveManager.instance.medium = true;
            stageText.text = "STAGE SIX";
        }
        if (levelNumber == 7)
        {
            WaveManager.instance.esay = false;
            WaveManager.instance.medium = true;
            stageText.text = "STAGE SEVEN";
        }
        if (levelNumber == 8)
        {
            WaveManager.instance.esay = false;
            WaveManager.instance.medium = true;
            stageText.text = "STAGE EIGHT";
        }
        if (levelNumber == 9)
        {
            WaveManager.instance.esay = false;
            WaveManager.instance.medium = true;
            stageText.text = "STAGE NINE";
        }
        if (levelNumber == 10)
        {
            stageText.text = "STAGE TEN";
        }
        if (levelNumber >= 11)
        {
            WaveManager.instance.esay = false;
            WaveManager.instance.medium = false;
            WaveManager.instance.hard = true;
            stageText.text = "GALAXYS EDGE";
        }
        if (Input.GetKeyDown(KeyCode.Space))
            {


                StartCoroutine(EndLevelCo());

            }

            Scene currentScence = SceneManager.GetActiveScene();
            string scenceName = currentScence.name;


            if (levelEnding)
            {
                PlayerController.instance.transform.position += new Vector3(0f, PlayerController.instance.boostSpeed * Time.deltaTime, 0f);
            }

            if (Input.GetKeyDown(KeyCode.K))
            {
                KillPlayer();
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
            } else
            {
                if (currentScore >= PlayerPrefs.GetInt("highScore10"))
                {
                    StartCoroutine(NewHighscoreCo());
                }
                else
                {
                    //GameOver
                    UIManager.instance.gameOverScreen.SetActive(true);
                    WaveManager.instance.canSpawnWaves = false;

                    PlayerPrefs.SetInt("HighSCORE", highScore);

                    PlayerPrefs.SetInt("score", currentScore);
                }
            }
        }

        public IEnumerator NewHighscoreCo()
        {
            UIManager.instance.gameOverAndNewHighscore.SetActive(true);
            WaveManager.instance.canSpawnWaves = false;
            yield return new WaitForSeconds(5);
            PlayerPrefs.SetInt("score", currentScore);
            SceneManager.LoadScene("NameSelect");
            Debug.Log("newHighScore");
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

            if (currentScore > highScore)
            {
                highScore = currentScore;
                UIManager.instance.highScoreText.text = "HI-SCORE: " + highScore;
            }
        }
    public void CollectCoin()
    {
        float vol = Random.Range(.5f, 1);
        source.PlayOneShot(coinSound, vol);
        amountOfCredits += 100;
        print("Coin Colleted");
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

            if (currentScore == highScore)
            {
                yield return new WaitForSeconds(.5f);
                UIManager.instance.highscoreNotice.SetActive(true);
            }
        //difculty increase
        
            levelNumber += 1;
            PlayerPrefs.SetInt("LevelNumber", levelNumber);
            PlayerPrefs.SetInt("HighSCORE", highScore);
            PlayerPrefs.SetInt("CurrentLives", currentLives);

            yield return new WaitForSeconds(waitForLevelEnd);

            SceneManager.LoadScene(nextLevel);

        }
    

}

