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

    public static IconManager instance;

    private void Awake(){
        instance = this;
    }

    public void changeImage(){
        tester = iconTextures[1];
        print(iconTextures[1]);
        newSprite = Sprite.Create(iconTextures[1], new Rect(0, 0, tester.width, tester.height), new Vector2(0.5f, 0.5f), 100.0f);
        instance.gameObject.GetComponentInChildren<RawImage>().texture = tester;
    }
}
