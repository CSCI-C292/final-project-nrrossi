using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] float _moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    public bool movementAllowed = true;

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


    void FixedUpdate() 
    {   
        if(movementAllowed){
            //Moves the character
            rb.MovePosition(rb.position + movement * _moveSpeed * Time.fixedDeltaTime);
        }
    }


    //When player in on a pipe, allows them to climb it
    private void OnTriggerStay2D(Collider2D other) 
    {   
        if(other.CompareTag("Pipe"))
            movement.y = Input.GetAxisRaw("Vertical");
    }

    //when player is off a pipe, prevents them from climbing.
    private void OnTriggerExit2D(Collider2D other) 
    {
        movement.y = 0;
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Finish")){
            Debug.Log("hole");
        }
    }

    public void movementToggle(){
        movementAllowed = !movementAllowed;
    }

}
