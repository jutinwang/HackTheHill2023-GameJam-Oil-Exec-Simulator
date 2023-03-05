using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUpdate : MonoBehaviour
{
    public Text Textfield;
    //public double currentFunds = OilButton.currentFunds;

    public static MoneyUpdate instance;

    private void Awake(){
        instance = this;
    }

    public void updateMoney(double value){
        print("Here: " + Textfield.text);
        Textfield.text = string.Format("{0:N2}", value);
    }

}
