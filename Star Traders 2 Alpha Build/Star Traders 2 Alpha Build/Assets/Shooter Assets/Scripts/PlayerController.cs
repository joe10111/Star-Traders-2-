using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public static PlayerController instance;
    //Vars for Moving Player
    public float moveSpeed;
    public Rigidbody2D theRB;
    public Animator animator;

    private IEnumerator coroutine;


    //Vars for Bondireis of player
    public Transform bottomLeftLimit, topRightlimit;

    public Transform shotPoint;
    public Transform shotPoint2;
    public Transform misslePoint;
    public GameObject shot;
    public GameObject shot2;
    public GameObject missle;
    public GameObject shotEffect;

    public float timeBetweenShots = 0.1f;
    public float missletimeBetweenShots = 2;

    private float shotCounter;
    private float missleshotCounter;

    private float normalSpeed;
    public float boostSpeed;
    public float boostLength;
    private float boostCounter;

    public bool stopMovement;

    public GameObject eShot;

    public bool Civ = true;
    public bool Class1 = false;
    public bool Class2 = false;
    public bool Class3 = false;

  


    // public bool dashReady = false;
    // private float dashCounter;
    // public float dashTime = 3;

    //public float dashDistances;

    public LayerMask bullet;
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
            animator.SetFloat("flying", Mathf.Abs(Movey));
            theRB.velocity = new Vector2(theRB.velocity.x, Movey * moveSpeed);

            transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.position.x, topRightlimit.position.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.position.y, topRightlimit.position.y), transform.position.z);

            shotCounter += Time.deltaTime;
            missleshotCounter += Time.deltaTime;
            print(missleshotCounter);
            
                // dashCounter += Time.deltaTime;

                //  if (dashCounter >= dashTime)
                //{
                //   dashReady = true;
                //   print("dash ready");
                // }

                //  if (Input.GetKeyDown(KeyCode.Q ) && dashReady == true)
                //  {
                //   transform.position += ( new Vector3( 0,dashDistances,0) * Time.deltaTime);
                // print("Dashed");
                // dashReady = false;
                //  dashCounter = 0;
                // }

                //print(shotCounter);
                //print(timeBetweenShots);

                if (Input.GetButtonDown("Fire1") && shotCounter >= timeBetweenShots)
               
            {
                Instantiate(shot, shotPoint.position, shotPoint.rotation);
                Instantiate(shotEffect, shotPoint.position, shotEffect.transform.rotation);
                Instantiate(shot2, shotPoint2.position, shotPoint.rotation);
                Instantiate(shotEffect, shotPoint2.position, shotEffect.transform.rotation);
                shotCounter = 0f;
            }
            //Ablitys
            //Shield
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Health.instance.ActivateShield();
            }
            //Abillity 2
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ActivateSpeedBoost();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3) && missleshotCounter >= missletimeBetweenShots)
            {
                Instantiate(missle, misslePoint.position, misslePoint.rotation);
                missleshotCounter = 0f;
                
            }
            //Ablitys
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
    public IEnumerator UpFireRate()
    {
        timeBetweenShots -= .1f;
        PlayerPrefs.SetFloat("UpFireRate", timeBetweenShots);
        print("upgraded fire");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level2");
    }
    public IEnumerator SpeedUp()
    {
        moveSpeed += 1;
        PlayerPrefs.SetFloat("SpeedUp", moveSpeed);
        print(moveSpeed);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level2");
    }
    

}
