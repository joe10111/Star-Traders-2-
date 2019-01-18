using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //Conncets the to scripts health and this one
    public static Health instance;
    //players health vars
    public int currentHealth;
    public int maxHealth;
    //Death animation call
    public GameObject deathEffect;

    public float invincibleLength = 2f;
    private float invincCounter;
    public SpriteRenderer theSR;

    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start ()
    {
        //setting current health
        currentHealth = maxHealth;

        UIManager.instance.healthBar.maxValue = maxHealth;
        UIManager.instance.healthBar.value = currentHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (invincCounter >= 0)
        {
            invincCounter -= Time.deltaTime;
            if(invincCounter <= 0)
            {
                theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, 1f);
            }
        }
    }

    public void DamageToPlayer()
    {
        if (invincCounter <= 0)
        {
            //docing the health if player gets hurt
            currentHealth--;
            UIManager.instance.healthBar.value = currentHealth;

            if (currentHealth <= 0)
            {
                Instantiate(deathEffect, transform.position, transform.rotation);
                gameObject.SetActive(false);

                GameManager.instance.KillPlayer();
                WaveManager.instance.canSpawnWaves = false;
            }
        }
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        currentHealth = maxHealth;
        UIManager.instance.healthBar.value = currentHealth;

        invincCounter = invincibleLength;
        theSR.color = new Color(theSR.color.r, theSR.color.g, theSR.color.b, .5f);
    }
}
