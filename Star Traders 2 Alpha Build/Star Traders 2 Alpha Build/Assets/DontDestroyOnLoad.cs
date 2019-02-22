using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DontDestroyOnLoad : MonoBehaviour
{
    public string Level1 = "Level1";
    private static DontDestroyOnLoad instance = null;
    public static DontDestroyOnLoad Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
    void Update()
    {
        Scene currentScence = SceneManager.GetActiveScene();
        string scenceName = currentScence.name;
        if (scenceName == Level1)
        {
            DestroyImmediate(gameObject);
        }
        }
}
