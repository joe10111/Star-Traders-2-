using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public float shotSpeed = 7f;
    public GameObject impactEffect;
    private Transform player;
    private Vector2 target;
    public bool trackingShot = false;
    

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerShotBox").transform;

        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if(trackingShot == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, shotSpeed * Time.deltaTime);
        }
        else
        {
            transform.position -= new Vector3(0f, shotSpeed * Time.deltaTime, 0f);
        }
            
       
      
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(impactEffect, transform.position, transform.rotation);
        if(other.tag == "Player")
        {
            Health.instance.DamageToPlayer();
        }
        Destroy(gameObject);
        if (other.tag == "ShotBox2")
        {
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
