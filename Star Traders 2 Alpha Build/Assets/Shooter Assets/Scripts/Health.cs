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

    private void Awake()
    {
        instance = this;
    }
    // Use this for initialization
    void Start ()
    {
        //setting current health
        currentHealth = maxHealth;   		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void DamageToPlayer()
    {
        //docing the health if player gets hurt
        currentHealth--;

        if (currentHealth <= 0)
        {
            Instantiate(deathEffect, transform.position, transform.rotation);
            gameObject.SetActive(false);
        }
    }
}
