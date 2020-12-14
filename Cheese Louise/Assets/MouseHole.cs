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
    
    private float count = 0;

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
            findCheeseFirst.gameObject.SetActive(false);
            playerMovement.movementToggle(false);
            
            //Advance to next level after enter is hit

        }
        else {
            findCheeseFirst.gameObject.SetActive(true);
        }
    }

}

