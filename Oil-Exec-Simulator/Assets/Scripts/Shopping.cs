using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shopping : MonoBehaviour{
    
    public GameObject PopUp;
    public GameObject Ending;

    public void Start(){
        PopUp.SetActive(false);
        Ending.SetActive(false);
    }

    public void ByeByeStore(){
        PopUp.SetActive(false);
    }

}