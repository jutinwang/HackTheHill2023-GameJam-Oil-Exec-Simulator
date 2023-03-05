using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//OilButton functionality script
public class OilButton : MonoBehaviour
{
    public double profits = 0;

    public double currentFunds = 0;

    public double moneyEarned = 80.0; 

    public int counter = 0;

    public Image tempBarFill;

    public int curTemp;
    public int maxTemp;

    //test function for testing onClick()
    public void Test(){
        counter++;
        profits += moneyEarned;
        print(profits);
        if (counter > 10){
            curTemp ++;
            //tempBarFill.fillAmount = (float)curTemp/(float)maxTemp;
            IconManager.instance.changeImage();
            print("profits increased!");
            moneyEarned += 10.0;
            counter = 0;
        }


    }
}
