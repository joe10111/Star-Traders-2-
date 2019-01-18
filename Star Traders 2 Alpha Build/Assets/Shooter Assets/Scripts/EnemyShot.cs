using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public float shotSpeed = 7f;
    public GameObject impactEffect;
    

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(shotSpeed * Time.deltaTime, 0f, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(impactEffect, transform.position, transform.rotation);
        if(other.tag == "Player")
        {
            Health.instance.DamageToPlayer();
        }
        Destroy(this.gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
