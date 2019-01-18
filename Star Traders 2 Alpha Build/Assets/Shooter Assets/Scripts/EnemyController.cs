using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;

    public Vector2 startDirection;

    public bool shouldChangeDirection;
    public float changeDirectionXpoint;
    public Vector2 changedDirection;

    public GameObject shotToFire;
    public Transform firePoint;
    public float timeBetweenShot;
    private float shotCounter;

    public bool canShoot;
    private bool allowShoot;

    public int currentHealth;
    public GameObject DeathEffect;


	// Use this for initialization
	void Start ()
    {
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
            if(transform.position.x > changeDirectionXpoint)
            {
                transform.position += new Vector3(startDirection.x * moveSpeed * Time.deltaTime, startDirection.y * moveSpeed * Time.deltaTime, 0f);
            }else
            {
                transform.position += new Vector3(changedDirection.x * moveSpeed * Time.deltaTime, changedDirection.y * moveSpeed * Time.deltaTime, 0f);
            }
        }
        if (allowShoot)
        {
            shotCounter -= Time.deltaTime;
            if (shotCounter <= 0)
            {
                shotCounter = timeBetweenShot;
                Instantiate(shotToFire, firePoint.position, firePoint.rotation);
            }
        }
    }
    public void DamageEnemy()
    {
        currentHealth--;
        if(currentHealth <- 0)
        {
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
