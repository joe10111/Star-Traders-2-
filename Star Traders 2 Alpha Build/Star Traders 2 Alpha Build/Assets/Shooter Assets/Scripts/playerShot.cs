using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShot : MonoBehaviour
{
    public float shotSpeed;
    public GameObject impactEffect;
    public GameObject objectExplostion;
    public static playerShot instance;
    //sin wave
    public bool sinWave = false;
    public bool sinWaveLeft = false;
    public bool sinWaveRight = false;
    public float amplitude = .0000000001f;
    public float amplitudePlus = .0000000001f;
    public float speed = 2;
    public float cyclesPerSecond = 1;
    float curTime = 0;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (sinWave == true)
        {
            transform.position += new Vector3(amplitude * Mathf.Sin(cyclesPerSecond * curTime * 2 * Mathf.PI), shotSpeed * Time.deltaTime, transform.position.z);
            amplitude += amplitudePlus * Time.deltaTime;
            curTime += Time.deltaTime;
            if (sinWaveLeft == true)
            {
                transform.position += new Vector3(-(amplitude * Mathf.Sin(cyclesPerSecond * curTime * 2 * Mathf.PI)), shotSpeed * Time.deltaTime, transform.position.z);
                amplitude += amplitudePlus * Time.deltaTime;
                curTime += Time.deltaTime;
            }
           
        }
        else
        {
            transform.position += new Vector3(0f, shotSpeed * Time.deltaTime, 0f);
        }
        
    }

    public IEnumerator UpBulletSpeed()
    {
        ///Dose not Work/////
        shotSpeed += 1;
        PlayerPrefs.SetFloat("UpBulletSpeed", shotSpeed);
        print(shotSpeed);
        yield return new WaitForSeconds(2);
        
        ///Dose not Work/////
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
