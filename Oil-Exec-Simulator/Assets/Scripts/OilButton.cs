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

    public Text textule;

    public string[] news = {"Greta thunberg arrested protesting Gessoline after a train derailed due to their lax safety regulations", "Your company has become a household name!", "Scientists worried at the worlds inaction against climate change",
    "A UN investigation finds that Gessoline is responsible for 80% of water pollution in the Gulf of Mexico", "Weather: Freezing rain to hit California this week",
    "G20 summit postponed due to hurricane", "Scientists shocked: phytoplankton which are responsible for the majority of the worlds oxygen are dying at a faster rate than ever",
    "Controversial decision by local big oil company to introduce children to the workforce following labor shortages", "President of China Wang Justin announces a nation-wide crude oil ban in response to the size of your company!", 
    "Breaking news - a representative from Gessoline has been arrested for bribery of a government official", "CEO of gessoline endorsed by climate deniers, including former president Arnold Rump", 
    "Son of Billionaire CEO of Gessoline, crashes mega-yacht worth 640 million dollars"};

    public List<string> stories;

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
        stories = new List<string>(news);
        AudioManager.instance.Play("pick");
        profits += moneyEarned;
        currentFunds += moneyEarned;
        MoneyUpdate.instance.updateMoney(currentFunds);
        MoneyEarned.instance.updateEarnedMoney();
        print(currentFunds);
        if (currentFunds >= 1250*counter){
            textule.text = news[counter];
        }
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
