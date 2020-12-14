using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{

    public MouseHole mouseHole;


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
    }

}
