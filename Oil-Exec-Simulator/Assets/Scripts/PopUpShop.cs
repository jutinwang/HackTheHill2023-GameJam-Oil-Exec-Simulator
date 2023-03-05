using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpShop : MonoBehaviour
{
    public static PopUpShop instance;

    public int oilRigs = 0;
    public double oilRigPrice = 5000.00;

    public double oilFieldPrice = 800000.00;
    public bool oilFieldBought = false;
    public int oilFields = 0;

    public double shallowRigPrice = 20000000.00;
    public bool shallowRigBought = false;
    public int shallowRigs = 0;

    public double deepSeaRigPrice = 500000000.00;
    public bool deepSeaRigBought = false;
    public int deepSeaRigs = 0;

    public double refineryPrice = 1000000000.00;
    public double refineryMultiplier = 0.00;

    private void Awake(){
        instance = this;
    }

    public void buyOilDrill(){
        if (OilButton.instance.currentFunds >= oilRigPrice){
            OilButton.instance.buyItem(oilRigPrice);
            oilRigs++;
            OilButton.instance.changeMoneyEarned(oilRigs * 80.0);
            print("bought");
        }else{
            AudioManager.instance.Play("chaching");
        }
    }

    public void buyOilField(){
        if (OilButton.instance.currentFunds >= oilFieldPrice & oilFieldBought == false){
            OilButton.instance.buyItem(oilFieldPrice);
            oilFieldBought = true;
            OilButton.instance.changeMoneyEarned(2000.0);
            print("bought");
        }
    }

    public void buyShallowRig(){
        if (OilButton.instance.currentFunds >= shallowRigPrice & shallowRigBought == false){
            OilButton.instance.buyItem(shallowRigPrice);
            shallowRigBought = true;
            OilButton.instance.changeMoneyEarned(20000.0);
            print("bought");
        }
    }

    public void buyDeepSeaRig(){
        if (OilButton.instance.currentFunds >= deepSeaRigPrice & deepSeaRigBought == false){
            OilButton.instance.buyItem(deepSeaRigPrice);
            deepSeaRigBought = true;
            OilButton.instance.changeMoneyEarned(1200000.0);
            print("bought");
        }
    }

    public void buyRefinery(){
        if (OilButton.instance.currentFunds >= refineryPrice){
            OilButton.instance.buyItem(refineryPrice);
            refineryMultiplier += 0.10;
            print("bought");

        }
    }


}
