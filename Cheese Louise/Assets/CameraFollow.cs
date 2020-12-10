using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;



    float xMax = 4f;
    float xMin = -4f;
    float yMax = 2.83f;
    float yMin = -2.83f;

    


    // Update is called once per frame
    void FixedUpdate()
    {
        //prevent camera from boundary. Shouldn't have to worry about the top.

        //Bottom Left Case
        if(target.position.x < xMin && target.position.y < yMin){
            transform.position = new Vector3(xMin, yMin, -10);
        }
        //Bottom Right Case
       else if(target.position.x > xMax && target.position.y < yMin){
            transform.position = new Vector3(xMax, yMin, -10);
        }
        //Bottom Case
        else if(target.position.y < yMin){
            transform.position = new Vector3(target.position.x, yMin, -10);
        }
        //Left Case{
        else if(target.position.x < xMin){
            transform.position = new Vector3(xMin, target.position.y, -10);
        }
        //Right Case
        else if(target.position.x > xMax){
            transform.position = new Vector3(xMax, target.position.y, -10);
        }
        else{
            //Camera Follows Player
            transform.position = new Vector3(target.position.x, target.position.y, -10);
        }
    }
}
