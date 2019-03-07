using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreInput : MonoBehaviour
{
    public static ScoreInput Instance;

    public InputField currentScoreField;

    public int scoreReal;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        FindScore();
    }

    public void ButtonScoreInput()
    {
        FindScore();
    }

    public void FindScore()
    {
      //  int.TryParse(currentScoreField.text, out scoreReal);
     //   currentScoreField.text = "score" + scoreReal;
        PlayerPrefs.SetInt("currentScore", scoreReal);
    }
}
