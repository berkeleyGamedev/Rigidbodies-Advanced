using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour {
    Rigidbody2D robot;
    float xAxis;

	// Use this for initialization
	void Start () {
        robot = GetComponent<Rigidbody2D>();
   
    }
	
	void FixedUpdate () {
        xAxis = Input.GetAxisRaw("Horizontal");

        //Keep in mind if you want custom movement controls you can always do things like this:

        //left = Input.GetKeyDown(KeyCode."Insert Your Key Here");
        //and then follow it up with other lines 

        //or something like this:

        //bool movingRight = false;
        //if (Input.GetKeyDown(KeyCode."Insert Button Here")):
        //      movingRight = true;
        //else:
        //      movingRight = false;
        //if (movingRight) {
        //    do stuff  
        //  }
      
        move1();
    }

    void move1() {
        //Continuously accelerates your robot!
        Vector2 movement = new Vector2(xAxis, 0);
        robot.AddForce(movement);
    }

    void move2() {
        //use Mathf.Clamp()
        Vector2 movement = new Vector2(xAxis, 0);
        movement = movement * 150;
        robot.AddForce(movement);
        //robot.velocity = new Vector2(Mathf.Clamp(robot.velocity.x, -3, 3), robot.velocity.y);

        //Note: This is a generic example meant to teach you about clamping. 
        //In the Unity Documentation there's a comment that warns against 
        //editing the velocity directly. I've done a lot of digging and really, 
        //it's not that dangerous. Just make sure to do .addForce inside of FixedUpdates
        //because those are physics steps. 
    }

    void move3() {
        //Make a movement function that instantaneously moves the robot right when "D" is pressed, and 
        //instantaneously moves the robot left when "A" is pressed. Robot should immediately stop if no 
        //button is pressed. 
    }

    void translate1() {
        Vector2 movement = new Vector2(xAxis, 0);
        robot.MovePosition(robot.position + movement);
    }
}
