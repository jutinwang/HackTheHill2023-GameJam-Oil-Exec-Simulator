using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpShop : MonoBehaviour
{
    public static PopUpShop instance;

    public int oilRigs = 0;
    public double oilRigPrice;

    public double oilFieldPrice;
    public bool oilFieldBought = false;
    public int oilFields = 0;

    public double shallowRigPrice;
    public bool shallowRigBought = false;
    public int shallowRigs = 0;

    public double deepSeaRigPrice;
    public bool deepSeaRigBought = false;
    public int deepSeaRigs = 0;

    public double refineryPrice;
    public double refineryMultiplier = 0.00;

    private void Awake(){
        instance = this;
    }

    public void buyOilDrill(){
        if (OilButton.instance.currentFunds >= oilRigPrice){
            OilButton.instance.buyItem(oilRigPrice);
            oilRigs++;
        }
    }

    public void buyOilField(){
        if (OilButton.instance.currentFunds >= oilFieldPrice & oilFieldBought == false){
            OilButton.instance.buyItem(oilFieldPrice);
            oilFieldBought = true;
        }
    }

    public void buyShallowRig(){
        if (OilButton.instance.currentFunds >= shallowRigPrice & shallowRigBought == false){
            OilButton.instance.buyItem(shallowRigPrice);
            shallowRigBought = true;
        }
    }

    public void buyDeepSeaRig(){
        if (OilButton.instance.currentFunds >= deepSeaRigPrice & deepSeaRigBought == false){
            OilButton.instance.buyItem(deepSeaRigPrice);
            deepSeaRigBought = true;
        }
    }

    public void buyRefinery(){
        if (OilButton.instance.currentFunds >= refineryPrice){
            OilButton.instance.buyItem(refineryPrice);
            refineryMultiplier += 0.10;
        }
    }


}
