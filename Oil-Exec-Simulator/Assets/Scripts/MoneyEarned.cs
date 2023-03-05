using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyEarned : MonoBehaviour
{
    public Text Textfield;

    public static MoneyEarned instance;

    private void Awake(){
        instance = this;
    }

    public void updateEarnedMoney(){
        Textfield.text = string.Format("{0:N2}", OilButton.instance.moneyEarned);
    }
}
