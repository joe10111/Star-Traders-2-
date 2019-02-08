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
    public Transform shotPoint2;
    public GameObject shot;

    public float timeBetweenShots = 0.1f;

    private float shotCounter;
   
    private float normalSpeed;
    public float boostSpeed;
    public float boostLength;
    private float boostCounter;

    public bool stopMovement;

    public bool dashReady = false;
    private float dashCounter;
    public float dashTime = 3;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start ()
    {
        normalSpeed = moveSpeed;
        theRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
      

        if (!stopMovement)
        {
           
           

            float Movex = Input.GetAxis("Horizontal");
            theRB.velocity = new Vector2(Movex* moveSpeed, theRB.velocity.y);

            float Movey = Input.GetAxis("Vertical");

            theRB.velocity = new Vector2(theRB.velocity.x, Movey * moveSpeed);

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.position.x, topRightlimit.position.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.position.y, topRightlimit.position.y), transform.position.z);

            shotCounter += Time.deltaTime;

            dashCounter += Time.deltaTime;

            if (dashCounter >= dashTime)
            {
                dashReady = true;
                print("dash ready");
            }

            if (Input.GetKeyDown(KeyCode.A) && dashReady == true)
            {
                theRB.AddForce(transform.up * 10);
                print("A pressed");
                dashReady = false;
                dashCounter = 0;
            }
            //print(shotCounter);
            //print(timeBetweenShots);

            if (Input.GetButtonDown("Fire1") && shotCounter >= timeBetweenShots)
               
            {
                Instantiate(shot, shotPoint.position, shotPoint.rotation);
                Instantiate(shot, shotPoint2.position, shotPoint.rotation);
                shotCounter = 0f;
            }


           

            if (boostCounter > 0)
            {
                boostCounter -= Time.deltaTime;
                if (boostCounter <= 0)
                {
                    moveSpeed = normalSpeed;
                }
            }
        }
        else
        {
            theRB.velocity = Vector2.zero;
        }
    }

    public void ActivateSpeedBoost()
    {
        boostCounter = boostLength;
        moveSpeed = boostSpeed;
    }
}
