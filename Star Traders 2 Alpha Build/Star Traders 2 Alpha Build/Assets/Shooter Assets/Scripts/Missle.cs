using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : MonoBehaviour
{
    public GameObject missleExpload;
    public GameObject DeathEffect;

    // Start is called before the first frame update
    void Start()
    {
        PlayerController.instance.missle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(missleExpload, transform.position, transform.rotation);
            Instantiate(DeathEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(missleExpload, transform.position, transform.rotation);
            Instantiate(DeathEffect, transform.position, transform.rotation);
            
        }
    }
}
