using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveTextOne: MonoBehaviour
{
    public float scrollDown = 0f;
    public float scrollReset = .1f;

    public float moveFirst = .25f;

    public GameObject firstst;
    public GameObject secondObj;
    public GameObject thirdObj;

    public GameObject box;

    public bool firstMove;
    public bool secondMove;
    public bool thirdMove;

    public Vector3 firstPosition;
    public Vector3 secondPosition;
    public Vector3 thirdPosition;

    public Button reset;

    public float boxMove = 1.25f;

    private void Start()
    {
        scrollDown = 0f;
        firstMove = true;

        firstPosition = firstst.transform.position;
        secondPosition = secondObj.transform.position;
        thirdPosition = thirdObj.transform.position;

        Debug.Log(firstPosition);
    }

    // Update is called once per frame
    void Update()
    {
        if (firstMove == true)
        {
            if (Input.GetKey(KeyCode.UpArrow) && firstst.transform.position.y > -0.5)
            {
                if (scrollDown <= 0)
                {
                    firstst.transform.Translate(0, -moveFirst, 0);
                    scrollDown = scrollReset;
                }
                scrollDown -= Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow) && firstst.transform.position.y < 20.5)
            {
                if (scrollDown <= 0)
                {
                    firstst.transform.Translate(0, moveFirst, 0);
                    scrollDown = scrollReset;
                }
                scrollDown -= Time.deltaTime;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
            {
                scrollDown = 0;
            }

            box.transform.position = new Vector3(-boxMove,0,0);
        }

        if (secondMove == true)
        {
            if (Input.GetKey(KeyCode.UpArrow) && secondObj.transform.position.y > -0.5)
            {
                if (scrollDown <= 0)
                {
                    secondObj.transform.Translate(0, -moveFirst, 0);
                    scrollDown = scrollReset;
                }
                scrollDown -= Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow) && secondObj.transform.position.y < 20.5)
            {
                if (scrollDown <= 0)
                {
                    secondObj.transform.Translate(0, moveFirst, 0);
                    scrollDown = scrollReset;
                }
                scrollDown -= Time.deltaTime;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
            {
                scrollDown = 0;
            }
            box.transform.position = new Vector3(0, 0, 0);
        }

        if (thirdMove == true)
        {
            if (Input.GetKey(KeyCode.UpArrow) && thirdObj.transform.position.y > -0.5)
            {
                if (scrollDown <= 0)
                {
                    thirdObj.transform.Translate(0, -moveFirst, 0);
                    scrollDown = scrollReset;
                }
                scrollDown -= Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow) && thirdObj.transform.position.y < 20.5)
            {
                if (scrollDown <= 0)
                {
                    thirdObj.transform.Translate(0, moveFirst, 0);
                    scrollDown = scrollReset;
                }
                scrollDown -= Time.deltaTime;
            }
            if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
            {
                scrollDown = 0;
            }
            box.transform.position = new Vector3(boxMove, 0, 0);
        }

        if(firstMove ==false && secondMove==false && thirdMove==false && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("HighScores");
        }

        if(Input.GetKeyDown(KeyCode.Backspace))
        {
            firstst.transform.position = firstPosition;
            secondObj.transform.position = secondPosition;
            thirdObj.transform.position = thirdPosition;

            firstMove = true;
            secondMove = false;
            thirdMove = false;

            reset.Select();
        }

    }
}

