using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MouseHole : MonoBehaviour
{
    public Text levelComplete;
    public Text findCheeseFirst;
    public Text proceed;

    public Cheese cheese;
    public PlayerMovement playerMovement;
    
    public bool gameComplete = false;

private void Awake() {
        levelComplete.gameObject.SetActive(false);
        findCheeseFirst.gameObject.SetActive(false);
        proceed.gameObject.SetActive(false);

        
}
    public void mouseExit()
    {
        if(cheese.hasCheese() == true){
            levelComplete.gameObject.SetActive(true);
            proceed.gameObject.SetActive(true);
            playerMovement.movementToggle(false);
            //Advance to next level after enter is hit

            gameComplete = true;
        }

        else {
            findCheeseFirst.gameObject.SetActive(true);
        }
    }

}

