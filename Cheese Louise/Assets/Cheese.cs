using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheese : MonoBehaviour
{

    private bool playerHasCheese = false;
    public GameObject cheeseForMouse; 
    public Image cheeseIcon;

    private void Awake() {
        cheeseIcon.gameObject.SetActive(false); //creates the Icon and make it inactive
    }

    //Get boolean for Mousehole.
    public bool hasCheese(){
        return playerHasCheese;
    }


    //Function that sets cheese bool to true and activates cheese icon and diactivates cheese on level
    public void playerGotCheese(){
        playerHasCheese = true;     //Sets Boolean to true
        cheeseIcon.gameObject.SetActive(true);  //Enables Cheese Icon
        cheeseForMouse.SetActive(false);    //Disables Cheese On Map
    }

    //Checks if mouse touched cheese and calls playerGotCheese Function
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Cheese")){
            playerGotCheese();
        }
    }


}
