using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseHole : MonoBehaviour
{

    [SerializeField] GameObject player;

    public Text levelComplete;
    public Text findCheeseFirst;

private void Awake() {
        levelComplete.gameObject.SetActive(false);
        findCheeseFirst.gameObject.SetActive(false);
       // player = GameObject.Find("Player");
        
}
    public void mouseExit()
    {
        if(true == true){
            Debug.Log("Works");

        }
        else {
                Debug.Log("No Cheese");
        }
    }


    private void OnTriggerEnter2D(Collider2D other) {   
        if(other.CompareTag("Finish")){
            Debug.Log("At Hole");
            mouseExit();

        }
    }

}

