using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUpdate : MonoBehaviour
{
    public Text Textfield;
    public double currentFunds = OilButton.currentFunds;

    public void updateMoney(ref currentFunds){
        Textfield.text = currentFunds;
    }

}
