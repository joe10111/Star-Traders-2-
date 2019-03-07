using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public int prevScore;
    public int highScore;
    public int highScore2;
    public int highScore3;
    public int highScore4;
    public int highScore5;
    public int highScore6;
    public int highScore7;
    public int highScore8;
    public int highScore9;
    public int highScore10;

    public string name;
    public string name1;
    public string name2;
    public string name3;
    public string name4;
    public string name5;
    public string name6;
    public string name7;
    public string name8;
    public string name9;
    public string name10;

    public Text scoreDisplay;
    public Text scoreHighScoreDisplay;
    public Text scoreHighScoreDisplay2;
    public Text scoreHighScoreDisplay3;
    public Text scoreHighScoreDisplay4;
    public Text scoreHighScoreDisplay5;
    public Text scoreHighScoreDisplay6;
    public Text scoreHighScoreDisplay7;
    public Text scoreHighScoreDisplay8;
    public Text scoreHighScoreDisplay9;
    public Text scoreHighScoreDisplay10;

    public Text nameText1;
    public Text nameText2;
    public Text nameText3;
    public Text nameText4;
    public Text nameText5;
    public Text nameText6;
    public Text nameText7;
    public Text nameText8;
    public Text nameText9;
    public Text nameText10;

    public InputField scoreField;
    public InputField nameField;

    private ScoreInput ScoreInputScript;

    private void Awake()
    {
        ScoreInput scoreInputNew = gameObject.AddComponent<ScoreInput>();

        Debug.Log(PlayerPrefs.GetInt("currentScore"));

    }

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore");
        highScore2 = PlayerPrefs.GetInt("highScore2");
        highScore3 = PlayerPrefs.GetInt("highScore3");
        highScore4 = PlayerPrefs.GetInt("highScore4");
        highScore5 = PlayerPrefs.GetInt("highScore5");
        highScore6 = PlayerPrefs.GetInt("highScore6");
        highScore7 = PlayerPrefs.GetInt("highScore7");
        highScore8 = PlayerPrefs.GetInt("highScore8");
        highScore9 = PlayerPrefs.GetInt("highScore9");
        highScore10 = PlayerPrefs.GetInt("highScore10");

        name1 = PlayerPrefs.GetString("name1");
        name2 = PlayerPrefs.GetString("name2");
        name3 = PlayerPrefs.GetString("name3");
        name4 = PlayerPrefs.GetString("name4");
        name5 = PlayerPrefs.GetString("name5");
        name6 = PlayerPrefs.GetString("name6");
        name7 = PlayerPrefs.GetString("name7");
        name8 = PlayerPrefs.GetString("name8");
        name9 = PlayerPrefs.GetString("name9");
        name10 = PlayerPrefs.GetString("name10");

        scoreHighScoreDisplay.text = "High Score 1: " + PlayerPrefs.GetInt("highScore");
        scoreHighScoreDisplay2.text = "High Score 2: " + PlayerPrefs.GetInt("highScore2");
        scoreHighScoreDisplay3.text = "High Score 3: " + PlayerPrefs.GetInt("highScore3");
        scoreHighScoreDisplay4.text = "High Score 4: " + PlayerPrefs.GetInt("highScore4");
        scoreHighScoreDisplay5.text = "High Score 5: " + PlayerPrefs.GetInt("highScore5");
        scoreHighScoreDisplay6.text = "High Score 6: " + PlayerPrefs.GetInt("highScore6");
        scoreHighScoreDisplay7.text = "High Score 7: " + PlayerPrefs.GetInt("highScore7");
        scoreHighScoreDisplay8.text = "High Score 8: " + PlayerPrefs.GetInt("highScore8");
        scoreHighScoreDisplay9.text = "High Score 9: " + PlayerPrefs.GetInt("highScore9");
        scoreHighScoreDisplay10.text = "High Score 10: " + PlayerPrefs.GetInt("highScore10");

        nameText1.text = PlayerPrefs.GetString("name1");
        nameText2.text = PlayerPrefs.GetString("name2");
        nameText3.text = PlayerPrefs.GetString("name3");
        nameText4.text = PlayerPrefs.GetString("name4");
        nameText5.text = PlayerPrefs.GetString("name5");
        nameText6.text = PlayerPrefs.GetString("name6");
        nameText7.text = PlayerPrefs.GetString("name7");
        nameText8.text = PlayerPrefs.GetString("name8");
        nameText9.text = PlayerPrefs.GetString("name9");
        nameText10.text = PlayerPrefs.GetString("name10");

        highScore = 0;
        highScore2 = 0;
        highScore3 = 0;
        highScore4 = 0;
        highScore5 = 0;

        score = 0;
    }

    private void Update()
    {
        //Check for High Scores
        if(score > PlayerPrefs.GetInt("highScore", highScore) && score!=0)
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));
            PlayerPrefs.SetInt("highScore9", PlayerPrefs.GetInt("highScore8"));
            PlayerPrefs.SetInt("highScore8", PlayerPrefs.GetInt("highScore7"));
            PlayerPrefs.SetInt("highScore7", PlayerPrefs.GetInt("highScore6"));
            PlayerPrefs.SetInt("highScore6", PlayerPrefs.GetInt("highScore5"));
            PlayerPrefs.SetInt("highScore5", PlayerPrefs.GetInt("highScore4"));
            PlayerPrefs.SetInt("highScore4", PlayerPrefs.GetInt("highScore3"));
            PlayerPrefs.SetInt("highScore3", PlayerPrefs.GetInt("highScore2"));
            PlayerPrefs.SetInt("highScore2", PlayerPrefs.GetInt("highScore"));

            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
            PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("name1"));

            HighScoreInput();
            NameInput1();
        }
        if(score > PlayerPrefs.GetInt("highScore2", highScore2) && score < PlayerPrefs.GetInt("highScore", highScore))
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));
            PlayerPrefs.SetInt("highScore9", PlayerPrefs.GetInt("highScore8"));
            PlayerPrefs.SetInt("highScore8", PlayerPrefs.GetInt("highScore7"));
            PlayerPrefs.SetInt("highScore7", PlayerPrefs.GetInt("highScore6"));
            PlayerPrefs.SetInt("highScore6", PlayerPrefs.GetInt("highScore5"));
            PlayerPrefs.SetInt("highScore5", PlayerPrefs.GetInt("highScore4"));
            PlayerPrefs.SetInt("highScore4", PlayerPrefs.GetInt("highScore3"));
            PlayerPrefs.SetInt("highScore3", PlayerPrefs.GetInt("highScore2"));

            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
            PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));

            HighScoreInput2();
            NameInput2();
        }
        if (score > PlayerPrefs.GetInt("highScore3", highScore3) && score < PlayerPrefs.GetInt("highScore2", highScore2))
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));
            PlayerPrefs.SetInt("highScore9", PlayerPrefs.GetInt("highScore8"));
            PlayerPrefs.SetInt("highScore8", PlayerPrefs.GetInt("highScore7"));
            PlayerPrefs.SetInt("highScore7", PlayerPrefs.GetInt("highScore6"));
            PlayerPrefs.SetInt("highScore6", PlayerPrefs.GetInt("highScore5"));
            PlayerPrefs.SetInt("highScore5", PlayerPrefs.GetInt("highScore4"));
            PlayerPrefs.SetInt("highScore4", PlayerPrefs.GetInt("highScore3"));

            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
            PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));

            HighScoreInput3();
            NameInput3();
        }
        if (score > PlayerPrefs.GetInt("highScore4", highScore4) && score < PlayerPrefs.GetInt("highScore3", highScore3))
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));
            PlayerPrefs.SetInt("highScore9", PlayerPrefs.GetInt("highScore8"));
            PlayerPrefs.SetInt("highScore8", PlayerPrefs.GetInt("highScore7"));
            PlayerPrefs.SetInt("highScore7", PlayerPrefs.GetInt("highScore6"));
            PlayerPrefs.SetInt("highScore6", PlayerPrefs.GetInt("highScore5"));
            PlayerPrefs.SetInt("highScore5", PlayerPrefs.GetInt("highScore4"));

            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
            PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));
            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));

            HighScoreInput4();
            NameInput4();
        }
        if(score > PlayerPrefs.GetInt("highScore5", highScore5) && score < PlayerPrefs.GetInt("highScore4", highScore4))
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));
            PlayerPrefs.SetInt("highScore9", PlayerPrefs.GetInt("highScore8"));
            PlayerPrefs.SetInt("highScore8", PlayerPrefs.GetInt("highScore7"));
            PlayerPrefs.SetInt("highScore7", PlayerPrefs.GetInt("highScore6"));
            PlayerPrefs.SetInt("highScore6", PlayerPrefs.GetInt("highScore5"));

            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
            PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            PlayerPrefs.SetString("name6", PlayerPrefs.GetString("name5"));

            HighScoreInput5();
            NameInput5();
        }
        if (score > PlayerPrefs.GetInt("highScore6", highScore6) && score < PlayerPrefs.GetInt("highScore5", highScore5))
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));
            PlayerPrefs.SetInt("highScore9", PlayerPrefs.GetInt("highScore8"));
            PlayerPrefs.SetInt("highScore8", PlayerPrefs.GetInt("highScore7"));
            PlayerPrefs.SetInt("highScore7", PlayerPrefs.GetInt("highScore6"));
            
            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
            PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            PlayerPrefs.SetString("name7", PlayerPrefs.GetString("name6"));
            
            HighScoreInput6();
            NameInput6();
        }
        if (score > PlayerPrefs.GetInt("highScore7", highScore7) && score < PlayerPrefs.GetInt("highScore6", highScore6))
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));
            PlayerPrefs.SetInt("highScore9", PlayerPrefs.GetInt("highScore8"));
            PlayerPrefs.SetInt("highScore8", PlayerPrefs.GetInt("highScore7"));
                        
            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
            PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));
            PlayerPrefs.SetString("name8", PlayerPrefs.GetString("name7"));
            
            HighScoreInput7();
            NameInput7();
        }
        if (score > PlayerPrefs.GetInt("highScore8", highScore8) && score < PlayerPrefs.GetInt("highScore7", highScore7))
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));
            PlayerPrefs.SetInt("highScore9", PlayerPrefs.GetInt("highScore8"));

            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
            PlayerPrefs.SetString("name9", PlayerPrefs.GetString("name8"));

            HighScoreInput8();
            NameInput8();
        }
        if (score > PlayerPrefs.GetInt("highScore9", highScore9) && score < PlayerPrefs.GetInt("highScore8", highScore8))
        {
            PlayerPrefs.SetInt("highScore10", PlayerPrefs.GetInt("highScore9"));

            PlayerPrefs.SetString("name10", PlayerPrefs.GetString("name9"));
     
            HighScoreInput9();
            NameInput9();
        }
        if (score > PlayerPrefs.GetInt("highScore10", highScore10) && score < PlayerPrefs.GetInt("highScore9", highScore9))
        {
            HighScoreInput10();
            NameInput10();
        }

    }

    public void ShowPrefScore()
    {
        Debug.Log(PlayerPrefs.GetString("name1") + PlayerPrefs.GetInt("highScore"));
        Debug.Log(PlayerPrefs.GetString("name2") + PlayerPrefs.GetInt("highScore2"));
        Debug.Log(PlayerPrefs.GetString("name3") + PlayerPrefs.GetInt("highScore3"));
        Debug.Log(PlayerPrefs.GetString("name4") + PlayerPrefs.GetInt("highScore4"));
        Debug.Log(PlayerPrefs.GetString("name5") + PlayerPrefs.GetInt("highScore5")); 
        Debug.Log(PlayerPrefs.GetString("name6") + PlayerPrefs.GetInt("highScore6"));
        Debug.Log(PlayerPrefs.GetString("name7") + PlayerPrefs.GetInt("highScore7"));
        Debug.Log(PlayerPrefs.GetString("name8") + PlayerPrefs.GetInt("highScore8"));
        Debug.Log(PlayerPrefs.GetString("name9") + PlayerPrefs.GetInt("highScore9"));
        Debug.Log(PlayerPrefs.GetString("name10") + PlayerPrefs.GetInt("highScore10"));
    }

    //Finds the Current Score
    public void FindScore()
    {
        int.TryParse(scoreField.text, out score);
        scoreDisplay.text = "Score: " + score;
    }

    //Sets the Current Name
    public  void FindName()
    {
        name = nameField.text;
    }

    public void UpdateText()
    {
        nameText1.text = PlayerPrefs.GetString("name1");
        nameText2.text = PlayerPrefs.GetString("name2");
        nameText3.text = PlayerPrefs.GetString("name3");
        nameText4.text = PlayerPrefs.GetString("name4");
        nameText5.text = PlayerPrefs.GetString("name5");
        nameText6.text = PlayerPrefs.GetString("name6");
        nameText7.text = PlayerPrefs.GetString("name7");
        nameText8.text = PlayerPrefs.GetString("name8");
        nameText9.text = PlayerPrefs.GetString("name9");
        nameText10.text = PlayerPrefs.GetString("name10");

        scoreHighScoreDisplay.text = "High Score 1: " + PlayerPrefs.GetInt("highScore" );
        scoreHighScoreDisplay2.text = "High Score 2: " + PlayerPrefs.GetInt("highScore2" );
        scoreHighScoreDisplay3.text = "High Score 3: " + PlayerPrefs.GetInt("highScore3" );
        scoreHighScoreDisplay4.text = "High Score 4: " + PlayerPrefs.GetInt("highScore4" );
        scoreHighScoreDisplay5.text = "High Score 5: " + PlayerPrefs.GetInt("highScore5" );
        scoreHighScoreDisplay6.text = "High Score 6: " + PlayerPrefs.GetInt("highScore6" );
        scoreHighScoreDisplay7.text = "High Score 7: " + PlayerPrefs.GetInt("highScore7" );
        scoreHighScoreDisplay8.text = "High Score 8: " + PlayerPrefs.GetInt("highScore8" );
        scoreHighScoreDisplay9.text = "High Score 9: " + PlayerPrefs.GetInt("highScore9" );
        scoreHighScoreDisplay10.text = "High Score 10: " + PlayerPrefs.GetInt("highScore10" );
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>
    
    public void HighScoreInput()
    {
        //Sets highScore to scoreField
        int.TryParse(scoreField.text, out highScore);
        //Playerpref set to highscore
        PlayerPrefs.SetInt("highScore", highScore);

        UpdateText();

        Debug.Log("HS1");
    }
    public void HighScoreInput2()
    {
        //Sets highScore2 to scoreField
        int.TryParse(scoreField.text, out highScore2);
        //Player pres set to highscore2
        PlayerPrefs.SetInt("highScore2", highScore2);

        UpdateText();

        Debug.Log("HS2");
    }
    public void HighScoreInput3()
    {
        int.TryParse(scoreField.text, out highScore3);
        PlayerPrefs.SetInt("highScore3", highScore3);

        UpdateText();

        Debug.Log("HS3");
    }
    public void HighScoreInput4()
    {
        int.TryParse(scoreField.text, out highScore4);
        PlayerPrefs.SetInt("highScore4", highScore4);

        UpdateText();

        Debug.Log("HS4");
    }
    public void HighScoreInput5()
    {
        int.TryParse(scoreField.text, out highScore5);
        PlayerPrefs.SetInt("highScore5", highScore5);

        UpdateText();
 
        Debug.Log("HS5");
    }
    public void HighScoreInput6()
    {
        int.TryParse(scoreField.text, out highScore6);
        PlayerPrefs.SetInt("highScore6", highScore6);

        UpdateText();

        Debug.Log("HS6");
    }
    public void HighScoreInput7()
    {
        int.TryParse(scoreField.text, out highScore7);
        PlayerPrefs.SetInt("highScore7", highScore7);

        UpdateText();

        Debug.Log("HS7");
    }
    public void HighScoreInput8()
    {
        int.TryParse(scoreField.text, out highScore8);
        PlayerPrefs.SetInt("highScore8", highScore8);

        UpdateText();

        Debug.Log("HS8");
    }
    public void HighScoreInput9()
    {
        int.TryParse(scoreField.text, out highScore9);
        PlayerPrefs.SetInt("highScore9", highScore9);

        UpdateText();

        Debug.Log("HS9");
    }
    public void HighScoreInput10()
    {
        int.TryParse(scoreField.text, out highScore10);
        PlayerPrefs.SetInt("highScore10", highScore10);

        UpdateText();

        Debug.Log("HS10");
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public void NameInput1()
    {
        //sets name1 to name field (current name)
        name1 = nameField.text;
        //sets name to prefs
        PlayerPrefs.SetString("name1", name1);

        UpdateText();
    }
    public void NameInput2()
    {
        name2 = nameField.text;
        PlayerPrefs.SetString("name2", name2);

        UpdateText();
    }
    public void NameInput3()
    {
        name3 = nameField.text;
        PlayerPrefs.SetString("name3", name3);

        UpdateText();
    }
    public void NameInput4()
    {
        name4 = nameField.text;
        PlayerPrefs.SetString("name4", name4);

        UpdateText();
    }
    public void NameInput5()
    {
        name5 = nameField.text;
        PlayerPrefs.SetString("name5", name5);

        UpdateText();
    }
    public void NameInput6()
    {
        name6 = nameField.text;
        PlayerPrefs.SetString("name6", name6);

        UpdateText();
    }
    public void NameInput7()
    {
        name7 = nameField.text;
        PlayerPrefs.SetString("name7", name7);

        UpdateText();
    }
    public void NameInput8()
    {
        name8 = nameField.text;
        PlayerPrefs.SetString("name8", name8);

        UpdateText();
    }
    public void NameInput9()
    {
        name9 = nameField.text;
        PlayerPrefs.SetString("name9", name9);

        UpdateText();
    }
    public void NameInput10()
    {
        name10 = nameField.text;
        PlayerPrefs.SetString("name10", name10);

        UpdateText();
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////////////////
    /// </summary>

    public void resetPrefs()
    {
        PlayerPrefs.SetInt("highScore", 1);
        PlayerPrefs.SetInt("highScore2", 0);
        PlayerPrefs.SetInt("highScore3", 0);
        PlayerPrefs.SetInt("highScore4", 0);
        PlayerPrefs.SetInt("highScore5", 0);
        PlayerPrefs.SetInt("highScore6", 0);
        PlayerPrefs.SetInt("highScore7", 0);
        PlayerPrefs.SetInt("highScore8", 0);
        PlayerPrefs.SetInt("highScore9", 0);
        PlayerPrefs.SetInt("highScore10", 0);

        PlayerPrefs.SetString("name1", "Low Score");
        PlayerPrefs.SetString("name2", "---");
        PlayerPrefs.SetString("name3", "---");
        PlayerPrefs.SetString("name4", "---");
        PlayerPrefs.SetString("name5", "---");
        PlayerPrefs.SetString("name6", "---");
        PlayerPrefs.SetString("name7", "---");
        PlayerPrefs.SetString("name8", "---");
        PlayerPrefs.SetString("name9", "---");
        PlayerPrefs.SetString("name10", "---");

        scoreHighScoreDisplay.text = "High Score 1: " + PlayerPrefs.GetInt("highScore", highScore);
        scoreHighScoreDisplay2.text = "High Score 2: " + PlayerPrefs.GetInt("highScore2", highScore2);
        scoreHighScoreDisplay3.text = "High Score 3: " + PlayerPrefs.GetInt("highScore3", highScore3);
        scoreHighScoreDisplay4.text = "High Score 4: " + PlayerPrefs.GetInt("highScore4", highScore4);
        scoreHighScoreDisplay5.text = "High Score 5: " + PlayerPrefs.GetInt("highScore5", highScore5);
        scoreHighScoreDisplay6.text = "High Score 6: " + PlayerPrefs.GetInt("highScore6", highScore6);
        scoreHighScoreDisplay7.text = "High Score 7: " + PlayerPrefs.GetInt("highScore7", highScore7);
        scoreHighScoreDisplay8.text = "High Score 8: " + PlayerPrefs.GetInt("highScore8", highScore8);
        scoreHighScoreDisplay9.text = "High Score 9: " + PlayerPrefs.GetInt("highScore9", highScore9);
        scoreHighScoreDisplay10.text = "High Score 10: " + PlayerPrefs.GetInt("highScore10", highScore10);

        nameText1.text = PlayerPrefs.GetString("name1");
        nameText2.text = PlayerPrefs.GetString("name2");
        nameText3.text = PlayerPrefs.GetString("name3");
        nameText4.text = PlayerPrefs.GetString("name4");
        nameText5.text = PlayerPrefs.GetString("name5");
        nameText6.text = PlayerPrefs.GetString("name6");
        nameText7.text = PlayerPrefs.GetString("name7");
        nameText8.text = PlayerPrefs.GetString("name8");
        nameText9.text = PlayerPrefs.GetString("name9");
        nameText10.text = PlayerPrefs.GetString("name10");
    }
}