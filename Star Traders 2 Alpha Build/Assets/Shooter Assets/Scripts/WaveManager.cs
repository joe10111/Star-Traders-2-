using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    public WaveObject[] waves;

    public int currentwave;

    public float timeToNextWave;

    public bool canSpawnWaves;

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
                Instantiate(waves[currentwave].theWave, transform.position, transform.rotation);

                if (currentwave < waves.Length - 1)
                {
                    currentwave++;

                    timeToNextWave = waves[currentwave].timeToSpawn;
                }else
                {
                    canSpawnWaves = false;
                }
            }
        }
    }

    public void continueSpawning()
    {
        if(currentwave < waves.Length -1 && timeToNextWave > 0)
        {
            canSpawnWaves = true;
        }
    }
}

[System.Serializable]
public class WaveObject
{
    public float timeToSpawn;
    public EnemyWave theWave;
}
