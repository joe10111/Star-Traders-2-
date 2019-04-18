using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScriptForUpgrades : MonoBehaviour
{
    public static ScriptForUpgrades instance;

    public GameObject ug11, ug12, ug13, ug14, ug15;
    public GameObject ug21, ug22, ug23, ug24, ug25;
    public GameObject ug31, ug32, ug33, ug34, ug35;
    public GameObject ug41, ug42, ug43, ug44, ug45;
    public GameObject ug51, ug52, ug53, ug54, ug55;



    public GameObject purchased;
    public GameObject notEnoughFunds;
    public GameObject fullyPurchased;

    public bool fug11, fug12, fug13, fug14, fug15;
    public bool fug21, fug22, fug23, fug24, fug25;
    public bool fug31, fug32, fug33, fug34, fug35;
    public bool fug41, fug42, fug43, fug44, fug45;
    public bool fug51, fug52, fug53, fug54, fug55;

    public bool shipcolor1, shipcolor2, shipcolor3, shipcolor4;

    public Text coinsDisplay;

    public int coinsValue;

    public int upgradeCost1 = 100;
    public int upgradeCost2 = 100;
    public int upgradeCost3 = 100;
    public int upgradeCost4 = 100;
    public int upgradeCost5 = 100;

    public float playerSpeed;

    public bool sheildActive = false;
    public bool dodgeActive = false;
    public bool missleActive = false;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        fug11 = false;
        fug12 = false;
        fug13 = false;
        fug14 = false;
        fug15 = false;
        fug21 = false;
        fug22 = false;
        fug23 = false;
        fug24 = false;
        fug25 = false;
        fug31 = false;
        fug32 = false;
        fug33 = false;
        fug34 = false;
        fug35 = false;
        fug41 = false;
        fug42 = false;
        fug43 = false;
        fug44 = false;
        fug45 = false;
        fug51 = false;
        fug52 = false;
        fug53 = false;
        fug54 = false;
        fug55 = false;

        ug11.SetActive(false);
        ug12.SetActive(false);
        ug13.SetActive(false);
        ug14.SetActive(false);
        ug15.SetActive(false);
        ug21.SetActive(false);
        ug22.SetActive(false);
        ug23.SetActive(false);
        ug24.SetActive(false);
        ug25.SetActive(false);
        ug31.SetActive(false);
        ug32.SetActive(false);
        ug33.SetActive(false);
        ug34.SetActive(false);
        ug35.SetActive(false);
        ug41.SetActive(false);
        ug42.SetActive(false);
        ug43.SetActive(false);
        ug44.SetActive(false);
        ug45.SetActive(false);
        ug51.SetActive(false);
        ug52.SetActive(false);
        ug53.SetActive(false);
        ug54.SetActive(false);
        ug55.SetActive(false);



        coinsValue = PlayerPrefs.GetInt("NumberOfCoins");
        coinsValue = 200;

        coinsDisplay.text = "" + coinsValue;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            SceneManager.LoadScene("Level2");
        }
    }

    public void ButtonSelect1()
    {
        if (coinsValue < upgradeCost1)
        {
            StartCoroutine(jesus());
        }

        if (fug11 == true && fug12 == true && fug13 == true && fug14 == true && fug15 == true)
        {
            StartCoroutine(fullyUpgraded());
        }
        if (fug11 == true && fug12 == true && fug13 == true && fug14 == true && fug15 == false && coinsValue >= upgradeCost1)
        {
            ug15.SetActive(true);
            fug15 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug11 == true && fug12 == true && fug13 == true && fug14 == false && coinsValue >= upgradeCost1)
        {
            ug14.SetActive(true);
            fug14 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug11 == true && fug12 == true && fug13 == false && fug14 == false && coinsValue >= upgradeCost1)
        {
            ug13.SetActive(true);
            fug13 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug11 == true && fug12 == false && fug13 == false && fug14 == false && coinsValue >= upgradeCost1)
        {
            ug12.SetActive(true);
            fug12 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug11 == false && coinsValue >= upgradeCost1)
        {
            fug11 = true;
            ug11.SetActive(true);
            missleActive = true;
            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
    }

    public void ButtonSelect2()
    {
        if (coinsValue < upgradeCost1)
        {
            StartCoroutine(jesus());
        }
        
        if (fug21 == true && fug22 == true && fug23 == true && fug24 == true && fug25 == true)
        {
            StartCoroutine(fullyUpgraded());
        }
        if (fug21 == true && fug22 == true && fug23 == true && fug24 == true && fug25 == false && coinsValue >= upgradeCost2)
        {
            ug25.SetActive(true);
            fug25 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug21 == true && fug22 == true && fug23 == true && fug24 == false && coinsValue >= upgradeCost1)
        {
            ug24.SetActive(true);
            fug24 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug21 == true && fug22 == true && fug23 == false && fug24 == false && coinsValue >= upgradeCost1)
        {
            ug23.SetActive(true);
            fug23 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug21 == true && fug22 == false && fug23 == false && fug24 == false && coinsValue >= upgradeCost1)
        {
            ug22.SetActive(true);
            fug22 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug21 == false && coinsValue >= upgradeCost1)
        {
            fug21 = true;
            ug21.SetActive(true);
            sheildActive = true;
            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
    }

    public void ButtonSelect3()
    {
        if (coinsValue < upgradeCost3)
        {
            StartCoroutine(jesus());
        }

        if (fug31 == true && fug32 == true && fug33 == true && fug34 == true && fug35 == true)
        {
            StartCoroutine(fullyUpgraded());
        }
        if (fug31 == true && fug32 == true && fug33 == true && fug34 == true && fug35 == false && coinsValue >= upgradeCost3)
        {
            ug35.SetActive(true);
            fug35 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug31 == true && fug32 == true && fug33 == true && fug34 == false && coinsValue >= upgradeCost3)
        {
            ug24.SetActive(true);
            fug24 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug31 == true && fug32 == true && fug33 == false && fug34 == false && coinsValue >= upgradeCost3)
        {
            ug23.SetActive(true);
            fug23 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug31 == true && fug32 == false && fug33 == false && fug34 == false && coinsValue >= upgradeCost3)
        {
            ug32.SetActive(true);
            fug32 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug31 == false && coinsValue >= upgradeCost3)
        {
            fug31 = true;
            ug31.SetActive(true);
            dodgeActive = true;
            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
    }

    public void ButtonSelect4()
    {
        if (coinsValue < upgradeCost4)
        {
            StartCoroutine(jesus());
        }

        if (fug41 == true && fug42 == true && fug43 == true && fug44 == true && fug45 == true)
        {
            StartCoroutine(fullyUpgraded());
        }
        if (fug41 == true && fug42 == true && fug43 == true && fug44 == true && fug45 == false && coinsValue >= upgradeCost4)
        {
            StartCoroutine(PlayerController.instance.UpFireRate());
            ug45.SetActive(true);
            fug45 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug41 == true && fug42 == true && fug43 == true && fug44 == false && coinsValue >= upgradeCost4)
        {
            StartCoroutine(PlayerController.instance.UpFireRate());
            ug44.SetActive(true);
            fug44 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug41 == true && fug42 == true && fug43 == false && fug44 == false && coinsValue >= upgradeCost4)
        {
            StartCoroutine(PlayerController.instance.UpFireRate());
            ug43.SetActive(true);
            fug43 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug31 == true && fug32 == false && fug33 == false && fug34 == false && coinsValue >= upgradeCost4)
        {
            StartCoroutine(PlayerController.instance.UpFireRate());
            ug42.SetActive(true);
            fug42 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug41 == false && coinsValue >= upgradeCost4)
        {
            fug41 = true;
            ug41.SetActive(true);

            StartCoroutine(PlayerController.instance.UpFireRate());

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
    }

    public void ButtonSelect5()
    {
        if (coinsValue < upgradeCost5)
        {
            StartCoroutine(jesus());
        }

        if (fug51 == true && fug52 == true && fug53 == true && fug54 == true && fug55 == true)
        {
            StartCoroutine(fullyUpgraded());
        }
        if (fug51 == true && fug52 == true && fug53 == true && fug54 == true && fug55 == false && coinsValue >= upgradeCost5)
        {
            StartCoroutine(PlayerController.instance.SpeedUp());
            ug55.SetActive(true);
            fug55 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug51 == true && fug52 == true && fug53 == true && fug54 == false && coinsValue >= upgradeCost5)
        {
            StartCoroutine(PlayerController.instance.SpeedUp());
            ug54.SetActive(true);
            fug54 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());

        }
        if (fug51 == true && fug52 == true && fug53 == false && fug54 == false && coinsValue >= upgradeCost5)
        {
            StartCoroutine(PlayerController.instance.SpeedUp());
            ug53.SetActive(true);
            fug53 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug51 == true && fug52 == false && fug53 == false && fug54 == false && coinsValue >= upgradeCost5)
        {
            StartCoroutine(PlayerController.instance.SpeedUp());
            ug52.SetActive(true);
            fug52 = true;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
        if (fug51 == false && coinsValue >= upgradeCost5)
        {
            StartCoroutine(PlayerController.instance.SpeedUp());
            fug51 = true;
            ug51.SetActive(true);

            playerSpeed += 10;

            coinsValue -= 100;
            UpdateText();
            StartCoroutine(jesus1());
        }
    }

    public void UpdateText()
    {
        coinsDisplay.text = "" + coinsValue;

    }

    public IEnumerator jesus()
    {
        notEnoughFunds.SetActive(true);
        yield return new WaitForSeconds(2);
        notEnoughFunds.SetActive(false);
    }
    public IEnumerator jesus1()
    {
        purchased.SetActive(true);
        yield return new WaitForSeconds(2);
        purchased.SetActive(false);
    }
    public IEnumerator fullyUpgraded()
    {
        fullyPurchased.SetActive(true);
        yield return new WaitForSeconds(2);
        fullyPurchased.SetActive(false);
    }

    public void ShipColor1()
    {
        shipcolor1 = true;
        shipcolor2 = false;
        shipcolor3 = false;
        shipcolor4 = false;
    }
    public void ShipColor2()
    {
        shipcolor1 = false;
        shipcolor2 = true;
        shipcolor3 = false;
        shipcolor4 = false;
    }
    public void ShipColor3()
    {
        shipcolor1 = false;
        shipcolor2 = false;
        shipcolor3 = true;
        shipcolor4 = false;
    }
    public void ShipColor4()
    {
        shipcolor1 = false;
        shipcolor2 = false;
        shipcolor4 = false;
        shipcolor4 = true;
    }
}