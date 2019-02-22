using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlescreen : MonoBehaviour
{
    public Transform player;

    public GameObject titleScreen;

    public Transform titleScreenPos;

    public GameObject title;
    public GameObject title2;
    public GameObject title3;
    public GameObject pressStart;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = 6; 
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        print(timer);
        if(player.position.y >= 3)
        {
            titleScreen.SetActive(true);
            if(timer <= 4)
            {
                title.SetActive(true);
            }
            if (timer <= 2.5)
            {
                title2.SetActive(true);
            }
            if (timer <= 2)
            {
                title3.SetActive(true);
            }
            if (timer <= 1.5)
            {
                pressStart.SetActive(true);
            }
        }
    }
}
