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

    public int counter = 1;

    public Image temperatureIndicator;

    public static OilButton instance;

    public GameObject endingScreen;

    private void Awake(){
        instance = this;
    }

    public int curTemp;
    public int maxTemp;

    public void changeMoneyEarned(double value){
        moneyEarned += value;
    }

    public void moneyEarnedMultiplier(double multiplier){
        moneyEarned = moneyEarned * multiplier;
    }

    //test function for testing onClick()
    public void Test(){
        profits += moneyEarned;
        currentFunds += moneyEarned;
        MoneyUpdate.instance.updateMoney(currentFunds);
        print(currentFunds);
        if (currentFunds >= 100000000*counter){
            curTemp ++;
            counter++;
            if(counter >= 11){
                endingScreen.SetActive(true);
            }
            temperatureIndicator.fillAmount = (float)curTemp/(float)maxTemp;
            IconManager.instance.changeImage();
        }
    }

    public void buyItem(double price){
        currentFunds -= price;
    }
}
