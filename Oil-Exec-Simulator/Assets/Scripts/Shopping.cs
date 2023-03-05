using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shopping : MonoBehaviour{
    
    public GameObject PopUp;

    public void Start(){
        PopUp.SetActive(false);
    }

    public void ByeByeStore(){
        PopUp.SetActive(false);
    }

}