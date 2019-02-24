using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Upgrades : MonoBehaviour
{
    public static Upgrades instance;
    public GameObject FireRateUpText;
    public GameObject HealthUpText;
    public GameObject SpeedUpText;



    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }
    public void FireRateUp()
    {
        StartCoroutine(PlayerController.instance.UpFireRate());
        HealthUpText.SetActive(false);
        FireRateUpText.SetActive(false);
        SpeedUpText.SetActive(false);
    }
    ///Dose not Work to edit a prefabs value with saving it super anoying.
   /// public void BulletSpeed()
    //{
        //fix///
      //  StartCoroutine(playerShot.instance.UpBulletSpeed());
        //fix///
    //}
    public void HealthUp()
    {
        StartCoroutine(Health.instance.HealthUp());
        HealthUpText.SetActive(false);
        FireRateUpText.SetActive(false);
        SpeedUpText.SetActive(false);

    }
    public void Speed()
    {
        StartCoroutine(PlayerController.instance.SpeedUp());
        HealthUpText.SetActive(false);
        FireRateUpText.SetActive(false);
        SpeedUpText.SetActive(false);
    }
}
