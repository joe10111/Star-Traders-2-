﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;
    public Transform[] startingPositions;
    public WaveObject[] waves;

    public int currentwave;

    public float timeToNextWave;

    public bool canSpawnWaves;

    public GameObject[] waveType;

    public GameObject endWave;
    public Transform endWaveTransform;

    public bool level1;

    public bool esay;

    public bool medium;

    public bool hard;
    



    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
       

        timeToNextWave = waves[0].timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        

            if (canSpawnWaves)
        {
           

            timeToNextWave -= Time.deltaTime;
            if (timeToNextWave <= 0)
            {
                int rand = Random.Range(0, 3);

                int rand1 = Random.Range(2, 7);

                int rand2 = Random.Range(0, 7);

                int rand3 = Random.Range(2, 8);

                int rand4 = Random.Range(4, 10);


                if (level1 == true)
                    {
                    waves[currentwave].timeToSpawn = 5;
                    transform.position = startingPositions[rand].position;
                    Instantiate(waveType[rand1], transform.position, transform.rotation);
                    }
                else if(esay == true)
                    {
                    waves[currentwave].timeToSpawn = 3.5f;
                    transform.position = startingPositions[rand].position;
                    Instantiate(waveType[rand2], transform.position, transform.rotation);
                    }
                else if (medium == true)
                {
                    waves[currentwave].timeToSpawn = 3;
                    transform.position = startingPositions[rand].position;
                    Instantiate(waveType[rand3], transform.position, transform.rotation);
                }
                else if (hard == true)
                {
                    waves[currentwave].timeToSpawn = 2.5f;
                    transform.position = startingPositions[rand].position;
                    Instantiate(waveType[rand4], transform.position, transform.rotation);
                }
                if (currentwave < waves.Length - 1)
                    {
                    currentwave++;
                    if (level1 == true)
                    {
                        timeToNextWave = 5;
                    }
                    else if (esay == true)
                    {
                        timeToNextWave = 4f;
                    }
                    else if (medium == true)
                    {
                        timeToNextWave = 3.5f;
                    }
                    else if (hard == true)
                    {
                        timeToNextWave = 3f;
                    }
                    
                }else
                {
                    canSpawnWaves = false;
                    StartCoroutine(LevelEnd());
                 }
            }
        }
    }

    public void continueSpawning()
    {
        if(currentwave <= waves.Length -1 && timeToNextWave > 0)
        {
            canSpawnWaves = true;
            
        }
    }
    public IEnumerator LevelEnd()
    {
        yield return new WaitForSeconds(10);
        Instantiate(endWave, endWaveTransform.transform.position, endWaveTransform.transform.rotation);
    }
    
   }

[System.Serializable]
public class WaveObject
{
    public float timeToSpawn;
    public EnemyWave theWave;
}

