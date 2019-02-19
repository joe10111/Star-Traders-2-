using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShot : MonoBehaviour
{
    public float shotSpeed = 7f;
    public GameObject impactEffect;
    public GameObject objectExplostion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += new Vector3(0f, shotSpeed * Time.deltaTime, 0f);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        Instantiate(impactEffect, transform.position, transform.rotation);
        if (other.tag == "Space Object")
        {
            Instantiate(objectExplostion, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);

            GameManager.instance.AddScore(50);
        }
        if(other.tag == "Enemy")
        {
            other.GetComponent<EnemyController>().DamageEnemy();
        }
        Destroy(this.gameObject);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
