using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyUpdate : MonoBehaviour
{
    public Text Textfield;

    public static MoneyUpdate instance;

    private void Awake(){
        instance = this;
    }

    public void updateMoney(double value){
        Textfield.text = string.Format("{0:N2}", value);
    }

    public void updateEmployeeSalary(double value){
        Textfield.text = string.Format("{0:N2}", value);
    }

}
