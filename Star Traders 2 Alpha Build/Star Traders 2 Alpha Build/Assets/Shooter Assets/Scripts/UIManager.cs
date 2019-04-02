using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject gameOverScreen;

    public GameObject gameOverAndNewHighscore;

    public Text livesText;

    public Slider healthBar, shieldBar;

    public Text scoreText, highScoreText;

    public GameObject levelEndScreen;

    public Text endLevelScore, endCurrentScore;

    public GameObject highscoreNotice;

    public Image MissleIcon;


 

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);


    }

    public void QuitToMain()
    {

        SceneManager.LoadScene("Title Screen", LoadSceneMode.Single);

    }
}
