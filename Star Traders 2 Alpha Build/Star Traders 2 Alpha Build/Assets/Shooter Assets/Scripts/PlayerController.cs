using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public static PlayerController instance;
    //Vars for Moving Player
    public float moveSpeed;
    public Rigidbody2D theRB;

    //Vars for Bondireis of player
    public Transform bottomLeftLimit, topRightlimit;

    public Transform shotPoint;
    public GameObject shot;

    public float timeBetweenShots = 0.1f;

    private float shotCounter;
    private float normalSpeed;
    public float boostSpeed;
    public float boostLength;
    private float boostCounter;

    public bool stopMovement;
    
    
   private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start ()
    {
        normalSpeed = moveSpeed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!stopMovement)
        {
            theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.position.x, topRightlimit.position.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.position.y, topRightlimit.position.y), transform.position.z);

            if (Input.GetButtonDown("Fire1"))
            {
                Instantiate(shot, shotPoint.position, shotPoint.rotation);
                shotCounter = timeBetweenShots;
            }

            if (Input.GetButton("Fire1"))
            {
                shotCounter -= Time.deltaTime;
                if (shotCounter <= 0)
                {
                    Instantiate(shot, shotPoint.position, shotPoint.rotation);
                    shotCounter = timeBetweenShots;
                }
            }
        }
        if(boostCounter > 0)
        {
            boostCounter -= Time.deltaTime;
            if(boostCounter<= 0)
            {
                moveSpeed = normalSpeed;
            }
        }
    }

    public void ActivateSpeedBoost()
    {
        boostCounter = boostLength;
        moveSpeed = boostSpeed;
    }
}
