using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkInShop : MonoBehaviour
{
    
    public GameObject popUpBox;
    public Animator animator;
    
    public void PopUp()
    {
        popUpBox.SetActive(true);
        animator.SetTrigger("pop");
    }
}
