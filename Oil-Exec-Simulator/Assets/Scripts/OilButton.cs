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

    public Image temperatureIndicator;

    public static OilButton instance;

    private void Awake(){
        instance = this;
    }

    public int curTemp;
    public int maxTemp;

    //test function for testing onClick()
    public void Test(){
        counter++;
        moneyEarned = moneyEarned + (160 * PopUpShop.instance.oilRigs) + (2000 * PopUpShop.instance.oilFields) + (20000 * PopUpShop.instance.shallowRigs) + (4800000 * PopUpShop.instance.deepSeaRigs);
        moneyEarned += moneyEarned * PopUpShop.instance.refineryMultiplier;
        profits += moneyEarned;
        currentFunds += moneyEarned;
        MoneyUpdate.instance.updateMoney(currentFunds);
        print(profits);
        if (counter > 10){
            curTemp ++;
            temperatureIndicator.fillAmount = (float)curTemp/(float)maxTemp;
            IconManager.instance.changeImage();
            moneyEarned += 10.0;
            counter = 0;
        }
    }

    public void buyItem(double price){
        currentFunds -= price;
    }
}
