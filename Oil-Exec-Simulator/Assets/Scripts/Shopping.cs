using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animation))]
public class Shopping : MonoBehaviour
{
 
    public AnimationClip animationClip;
 
    float speed = -1f;
    new Animation animation;
 
    // Use this for initialization
    void Start () {
        this.animation = this.GetComponent<Animation>();
        if(this.animationClip == null)
        {
            Debug.Log(this.GetType().ToString() + ": Animation Clip needed");
            Destroy(this);
        }
    }
   
 
    //MonoBehaviour Event. Need Collider to work correctly
    void onClick()
    {
        if (this.animation.isPlaying) return; //exit
        this.speed = -this.speed;
        this.animation[this.animationClip.name].speed = this.speed;
        this.animation.Play(this.animationClip.name);
        if (this.speed < 0f) this.animation[this.animationClip.name].normalizedTime = 1f;
    }
}

    

