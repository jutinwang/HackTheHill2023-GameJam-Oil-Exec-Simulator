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
        AudioManager.instance.Play("pick");
        profits += moneyEarned;
        currentFunds += moneyEarned;
        MoneyUpdate.instance.updateMoney(currentFunds);
        MoneyEarned.instance.updateEarnedMoney();
        print(currentFunds);
        if (currentFunds >= 2500*counter){
            curTemp ++;
            counter++;
            if(counter >= 11){
                endingScreen.SetActive(true);
                AudioManager.instance.Play("elden");
            }
            temperatureIndicator.fillAmount = (float)curTemp/(float)maxTemp;
            float temp = (float)curTemp/(float)maxTemp;
            WorldMapManager.instance.changeImage(temp);
            IconManager.instance.changeImage();
            AudioManager.instance.Play("villager");
        }
    }

    public void buyItem(double price){
        currentFunds -= price;
    }
}
