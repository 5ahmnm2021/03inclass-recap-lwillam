using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    public InputField input1;
    public InputField input2;
    
    public Text result;
    
    bool num1 = true;
    bool num2 = true;
    
    //bool correctIn1 = false;
    //public bool correctIn2 = false;

    public void AddNumbersOnClick()

    
    {
        int ersteNummer = 0;
        int zweiteNummer = 0;

        int ergebnis = 0;

        string fehlerTxt = "Geben sie eine gültige Zahl ein";

        try
        {
            ersteNummer = int.Parse(input1.text);
            input1.image.color = Color.white;
            num1 = true;
        }
        catch (System.Exception)
        {
            input1.image.color = new Color32(255,0,0,100);
            input1.text = fehlerTxt;
            num1 = false;
        }

        try
        {
            zweiteNummer = int.Parse(input2.text);
            input2.image.color = Color.white;
            num2 = true;
        }
        catch (System.Exception)
        {
            input2.image.color = new Color32(255,0,0,100);
            input2.text = fehlerTxt;
            num2 = false;
        }
        
        if (num1 && num2)
        {
            ergebnis = ersteNummer + zweiteNummer;

            result.text = ergebnis.ToString();
        }
        else
        {
            result.text = "Incorect Input";
        }
        
    }
}
