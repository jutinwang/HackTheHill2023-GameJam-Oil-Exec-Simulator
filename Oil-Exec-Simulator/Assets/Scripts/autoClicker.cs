using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class autoClicker : MonoBehaviour
{
    public List<float> clickerEmployee = new List<float>();

    public float employeePrice;

    void Update(){
        for (int x = 0; x < clickerEmployee.Count; x++){
            if (Time.time - clickerEmployee[x] >= 1.0f){
                clickerEmployee[x] = Time.time;
                OilButton.instance.Test();
            }
        }
    }

    public void BuyEmployee(){
        if (OilButton.instance.currentFunds >= employeePrice){
            OilButton.instance.buyItem(employeePrice);
            clickerEmployee.Add(Time.time);
            MoneyUpdate.instance.updateEmployeeSalary(employeePrice);
        }
    }


}
