using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconManager : MonoBehaviour
{
    public Texture2D[] iconTextures;
    public Texture2D tester;
    public Sprite newSprite;
    public Image newImage;
    private int counter = 0;

    public static IconManager instance;

    private void Awake(){
        instance = this;
    }

    public void incrementCounter(){
        counter++;
    }

    public int getCounter(){
        return counter;
    }

    public void changeImage(){
        tester = iconTextures[counter];
        if (getCounter() != 4){
            incrementCounter();
        }
        instance.gameObject.GetComponentInChildren<RawImage>().texture = tester;
    }
}
