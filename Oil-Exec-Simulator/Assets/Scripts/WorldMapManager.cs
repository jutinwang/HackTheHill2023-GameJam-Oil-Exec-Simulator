using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldMapManager : MonoBehaviour
{
    public Texture2D[] maps;
    public Texture2D tester;

    public static WorldMapManager instance;

    private void Awake(){
        instance = this;
    }

    public void changeImage(float temperature){
            if (temperature >= 0.0 && temperature < 0.20){
                tester = maps[0];
                instance.gameObject.GetComponentInChildren<RawImage>().texture = tester;
            }else if (temperature >= 0.20 & temperature < 0.40){
                tester = maps[1];
                instance.gameObject.GetComponentInChildren<RawImage>().texture = tester;
            }else if (temperature >= 0.40 & temperature < 0.60){
                tester = maps[2];
                instance.gameObject.GetComponentInChildren<RawImage>().texture = tester;
            }else if (temperature >= 0.60 & temperature < 0.80){
                tester = maps[3];
                instance.gameObject.GetComponentInChildren<RawImage>().texture = tester;
            }else if (temperature >= 0.80){
                tester = maps[4];
                instance.gameObject.GetComponentInChildren<RawImage>().texture = tester;
            }
    }
}
