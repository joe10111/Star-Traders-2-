﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public static EnemyController instance;
    public float moveSpeed;

    public Vector2 startDirection;
    

    public bool shouldChangeDirection;
    public float changeDirectionXpoint, changeDirectionXpoint2;
    
    public Vector2 changedDirection, changedDirection2;
  
    public GameObject shotToFire;
    public Transform firePoint, firePoint2, firePoint3, firePoint4;
   
    public float timeBetweenShot;
    private float shotCounter;

    public bool canShoot;
    private bool allowShoot;

    public int currentHealth;
    public GameObject DeathEffect;

    public int scoreValue = 100;

    public GameObject[] coinDrop;
    public int dropSuccessRate = 15;

    public bool changedDir2 = true;
    public bool changedDir3 = true;

    private Transform player;

    public bool twoGuns = false;
    public bool threeGuns = false;
    public bool fourGuns = false;
    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        shotCounter = timeBetweenShot;	

	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!shouldChangeDirection)
        {
            transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
        } else
        {
            if (transform.position.y > changeDirectionXpoint && changedDir2 == true)
            {
                transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
            } else
            {
                transform.position += new Vector3(changedDirection.x * moveSpeed * Time.deltaTime, changedDirection.y * moveSpeed * Time.deltaTime, 0f);
            }
            if (transform.position.y > changeDirectionXpoint2)
            {
                changedDir2 = false;
                transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
            }
            else
            {
                changedDir2 = false;
                transform.position += new Vector3(changedDirection2.x * moveSpeed * Time.deltaTime, changedDirection2.y * moveSpeed * Time.deltaTime, 0f);
              
            }
           
        }
        if (allowShoot)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShot;
                Instantiate(shotToFire, firePoint.position, firePoint.rotation);
                if(twoGuns == true)
                {
                    Instantiate(shotToFire, firePoint2.position, firePoint2.rotation);
                }
                if (threeGuns == true)
                {
                    Instantiate(shotToFire, firePoint3.position, firePoint3.rotation);
                }
                if (fourGuns == true)
                {
                    Instantiate(shotToFire, firePoint4.position, firePoint4.rotation);
                }
            }
        }
    }
    public void DamageEnemy()
    {
        currentHealth--;
        if(currentHealth <= 0)
        {
            GameManager.instance.AddScore(scoreValue);

            int randomChance = Random.Range(0, 100);
             if(randomChance < dropSuccessRate)
             {
                int randomPick = Random.Range(0, coinDrop.Length);
                Instantiate(coinDrop[randomPick], transform.position, transform.rotation);
             }
            CameraShake.instance.shakeAmount = .07f;
            CameraShake.instance.shakeDuration = 0.09f;
            Destroy(gameObject);
            Instantiate(DeathEffect, transform.position, transform.rotation);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnBecameVisible()
    {
    if(canShoot)
        {
            allowShoot = true;
        }
    }
}
