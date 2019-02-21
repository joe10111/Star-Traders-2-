using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Loads current scene plus 1
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    //quits game if built else debug log = "quit'
    public void ExitGame ()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
