using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{

    public MouseHole mouseHole;

    public Text demoThanks;
    public Text proceed;


    private void FixedUpdate() {
        //Quit to Main Menu
        if (Input.GetButtonDown("Restart")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        //Reset Level
        if (Input.GetButtonDown("BackToMenu")){
            SceneManager.LoadScene(0);
        }
    

        if (Input.GetButtonDown("Submit") && mouseHole.gameComplete){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        mouseHole.gameComplete = false;
        }

        if((SceneManager.GetActiveScene().buildIndex == 2) && mouseHole.gameComplete){
            demoThanks.gameObject.SetActive(true);
            proceed.gameObject.SetActive(false);
        }
    }

}
