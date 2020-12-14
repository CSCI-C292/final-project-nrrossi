using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    ////////////////////////////////////////////////////////////////
    //
    //  Variables
    //
    [SerializeField] float _moveSpeed = 5f;
    [SerializeField] float _downSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    public bool movementAllowed = true;

    private MouseHole mouseHole;
    private void Start() {
        mouseHole = FindObjectOfType<MouseHole>();
    }


    /////////////////////////////////////////////////////////////////////////
    //
    //  Updating movement on X-axis and Animator
    //
    void Update() 
    {
        //Gets movements inputs in x-axis
        movement.x = Input.GetAxisRaw("Horizontal");

        //Sets animator stuff...
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        
       // Debug.Log(rb.velocity);
    }

    ///////////////////////////////////////////////////////
    //
    //  Moving the character and adding falling force
    //

    void FixedUpdate() 
    {   
        if(movementAllowed){
            //Moves the character
            rb.MovePosition(rb.position + movement * _moveSpeed * Time.fixedDeltaTime);
        }

        /*    //Falling Speed  
            if((movement.y == 0) || (rb.position.Equals(transform.position))){
                rb.AddForce(new Vector2(0, -1) * _downSpeed);
            } */

            if(rb.velocity.y < 0){Debug.Log("velocity is" + rb.velocity.y);}
    }









    /////////////////////////////////////////////////////
    //When player in on a pipe, allows them to climb it
    //
    private void OnTriggerStay2D(Collider2D other) 
    {   
        if(other.CompareTag("Pipe"))
            movement.y = Input.GetAxisRaw("Vertical");
    }

    ///////////////////////////////////////////////////////////
    //when player is off a pipe, prevents them from climbing.
    //
    private void OnTriggerExit2D(Collider2D other) 
    {
        movement.y = 0;
    }








    ////////////////////////////////////////////////////////
    //  Detects when mouse reaches the hole
    //
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Finish")){
            mouseHole.mouseExit();
        }
    }







    ///////////////////////////////////////////////
    //  Toggle Movement Capability
    //
    public void movementToggle(bool choice){
        movementAllowed = choice;
    }
}
