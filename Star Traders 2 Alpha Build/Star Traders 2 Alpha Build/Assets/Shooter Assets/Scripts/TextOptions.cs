using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOptions : MonoBehaviour
{
    public string firstCharactor;
    public string secondCharactor;
    public string thirdCharactor;

    public Button secondButton;
    public Button thirdButton;

    public GameObject scriptMove;

    private void Start()
    {
        PlayerPrefs.GetString("FirstCharactor");
        PlayerPrefs.GetString("SecondCharactor");
        PlayerPrefs.GetString("ThirdCharactor");

        scriptMove.GetComponent<MoveTextOne>().secondMove = false;
    }

    // // // // // // // // // // // // 

    public void A1()
    {
        firstCharactor = "A";
        SetFirstCharactor();
    }
    public void B1()
    {
        firstCharactor = "B";
        SetFirstCharactor();
    }
    public void C1()
    {
        firstCharactor = "C";
        SetFirstCharactor();
    }
    public void D1()
    {
        firstCharactor = "D";
        SetFirstCharactor();
    }
    public void E1()
    {
        firstCharactor = "E";
        SetFirstCharactor();
    }
    public void F1()
    {
        firstCharactor = "F";
        SetFirstCharactor();
    }
    public void G1()
    {
        firstCharactor = "G";
        SetFirstCharactor();
    }
    public void H1()
    {
        firstCharactor = "H";
        SetFirstCharactor();
    }
    public void I1()
    {
        firstCharactor = "I";
        SetFirstCharactor();
    }
    public void J1()
    {
        firstCharactor = "J";
        SetFirstCharactor();
    }
    public void K1()
    {
        firstCharactor = "K";
        SetFirstCharactor();
    }
    public void L1()
    {
        firstCharactor = "L";
        SetFirstCharactor();
    }
    public void M1()
    {
        firstCharactor = "M";
        SetFirstCharactor();
    }
    public void N1()
    {
        firstCharactor = "N";
        SetFirstCharactor();
    }
    public void O1()
    {
        firstCharactor = "O";
        SetFirstCharactor();
    }
    public void P1()
    {
        firstCharactor = "P";
        SetFirstCharactor();
    }
    public void Q1()
    {
        firstCharactor = "Q";
        SetFirstCharactor();
    }
    public void R1()
    {
        firstCharactor = "R";
        SetFirstCharactor();
    }
    public void S1()
    {
        firstCharactor = "S";
        SetFirstCharactor();
    }
    public void T1()
    {
        firstCharactor = "T";
        SetFirstCharactor();
    }
    public void U1()
    {
        firstCharactor = "U";
        SetFirstCharactor();
    }
    public void V1()
    {
        firstCharactor = "V";
        SetFirstCharactor();
    }
    public void W1()
    {
        firstCharactor = "W";
        SetFirstCharactor();
    }
    public void X1()
    {
        firstCharactor = "X";
        SetFirstCharactor();
    }
    public void Y1()
    {
        firstCharactor = "Y";
        SetFirstCharactor();
    }
    public void Z1()
    {
        firstCharactor = "Z";
        SetFirstCharactor();
    }

    // // // // // // // // // // // //

    public void A2()
    {
        secondCharactor = "A";
        SetSecondCharactor();
    }
    public void B2()
    {
        secondCharactor = "B";
        SetSecondCharactor();
    }
    public void C2()
    {
        secondCharactor = "C";
        SetSecondCharactor();
    }
    public void D2()
    {
        secondCharactor = "D";
        SetSecondCharactor();
    }
    public void E2()
    {
        secondCharactor = "E";
        SetSecondCharactor();
    }
    public void F2()
    {
        secondCharactor = "F";
        SetSecondCharactor();
    }
    public void G2()
    {
        secondCharactor = "G";
        SetSecondCharactor();
    }
    public void H2()
    {
        secondCharactor = "H";
        SetSecondCharactor();
    }
    public void I2()
    {
        secondCharactor = "I";
        SetSecondCharactor();
    }
    public void J2()
    {
        secondCharactor = "J";
        SetSecondCharactor();
    }
    public void K2()
    {
        secondCharactor = "K";
        SetSecondCharactor();
    }
    public void L2()
    {
        secondCharactor = "L";
        SetSecondCharactor();
    }
    public void M2()
    {
        secondCharactor = "M";
        SetSecondCharactor();
    }
    public void N2()
    {
        secondCharactor  = "N";
        SetSecondCharactor();
    }
    public void O2()
    {
        secondCharactor = "O";
        SetSecondCharactor();
    }
    public void P2()
    {
        secondCharactor = "P";
        SetSecondCharactor();
            }
    public void Q2()
    {
        secondCharactor = "Q";
        SetSecondCharactor();
    }
    public void R2()
    {
        secondCharactor = "R";
        SetSecondCharactor();
    }
    public void S2()
    {
        secondCharactor = "S";
        SetSecondCharactor();
    }
    public void T2()
    {
        secondCharactor = "T";
        SetSecondCharactor();
    }
    public void U2()
    {
        secondCharactor = "U";
        SetSecondCharactor();
    }
    public void V2()
    {
        secondCharactor = "V";
        SetSecondCharactor();
    }
    public void W2()
    {
        secondCharactor = "W";
        SetSecondCharactor();
    }
    public void X2()
    {
        secondCharactor = "X";
        SetSecondCharactor();
    }
    public void Y2()
    {
        secondCharactor = "Y";
        SetSecondCharactor();
    }
    public void Z2()
    {
        secondCharactor = "Z";
        SetSecondCharactor();
    }

    // // // // // // // // // // // //

    public void A3()
    {
        thirdCharactor = "A";
        SetThirdCharactor();
    }
    public void B3()
    {
        thirdCharactor = "B";
        SetThirdCharactor   ();
    }
    public void C3()
    {
        thirdCharactor = "C";
        SetThirdCharactor();
    }
    public void D3()
    {
        thirdCharactor = "D";
        SetThirdCharactor();
    }
    public void E3()
    {
        thirdCharactor   = "E";
        SetThirdCharactor();
    }
    public void F3()
    {
        thirdCharactor = "F";
        SetThirdCharactor   ();
    }
    public void G3()
    {
        thirdCharactor = "G";
        SetThirdCharactor();
    }
    public void H3()
    {
        thirdCharactor = "H";
        SetThirdCharactor();
    }
    public void I3()
    {
        thirdCharactor = "I";
        SetThirdCharactor();
    }
    public void J3()
    {
        thirdCharactor = "J";
        SetThirdCharactor   ();
    }
    public void K3()
    {
        thirdCharactor = "K";
        SetThirdCharactor();
    }
    public void L3()
    {
        thirdCharactor = "L";
        SetThirdCharactor();
    }
    public void M3()
    {
        thirdCharactor = "M";
        SetThirdCharactor();
    }
    public void N3()
    {
        thirdCharactor   = "N";
        SetThirdCharactor();
    }
    public void O3()
    {
        thirdCharactor = "O";
        SetThirdCharactor();
    }
    public void P3()
    {
        thirdCharactor   = "P";
        SetThirdCharactor();
    }
    public void Q3()
    {
        thirdCharactor = "Q";
        SetThirdCharactor();
    }
    public void R3()
    {
        thirdCharactor = "R";
        SetThirdCharactor();
    }
    public void S3()
    {
        thirdCharactor = "S";
        SetThirdCharactor();
    }
    public void T3()
    {
        thirdCharactor   = "T";
        SetThirdCharactor();
    }
    public void U3()
    {
        thirdCharactor = "U";
        SetThirdCharactor();
    }
    public void V3()
    {
        thirdCharactor   = "V";
        SetThirdCharactor();
    }
    public void W3()
    {
        thirdCharactor = "W";
        SetThirdCharactor();
    }
    public void X3()
    {
        thirdCharactor = "X";
        SetThirdCharactor();
    }
    public void Y3()
    {
        thirdCharactor = "Y";
        SetThirdCharactor   ();
    }
    public void Z3()
    {
        thirdCharactor= "Z";
        SetThirdCharactor ();
    }

    public void SetFirstCharactor()
    {
        PlayerPrefs.SetString("FirstCharactor", firstCharactor);
        scriptMove.GetComponent<MoveTextOne>().secondMove = true;
        scriptMove.GetComponent<MoveTextOne>().firstMove = false;

        secondButton.Select();
    }

    public void SetSecondCharactor()
    {
        PlayerPrefs.SetString("SecondCharactor", secondCharactor);
        scriptMove.GetComponent<MoveTextOne>().thirdMove = true;
        scriptMove.GetComponent<MoveTextOne>().secondMove = false;

        thirdButton.Select();
    }
    public   void SetThirdCharactor()
    {
        PlayerPrefs.SetString("ThirdCharactor", thirdCharactor);

        scriptMove.GetComponent<MoveTextOne>().thirdMove = false;
        scriptMove.GetComponent<MoveTextOne>().box.SetActive(false);

        CombineStrings();
    }
    public void CombineStrings()
    {
        PlayerPrefs.SetString("CurrentName", PlayerPrefs.GetString("FirstCharactor") + PlayerPrefs.GetString("SecondCharactor") + PlayerPrefs.GetString("ThirdCharactor"));
    }
}
