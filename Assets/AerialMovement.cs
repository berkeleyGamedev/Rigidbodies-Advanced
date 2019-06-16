using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AerialMovement : MonoBehaviour {
    Rigidbody2D robot;
    float xAxis;
    public bool canJump;

    // Use this for initialization
    void Start () {
        robot = GetComponent<Rigidbody2D>();
        canJump = false;
	}
	
	// Update is called once per frame
	void Update () {
        xAxis = Input.GetAxisRaw("Horizontal");
        move1();
        if (Input.GetKeyDown(KeyCode.W) && canJump == true) {
            jump();
        }
	}

    void move1() {
        //Fill in whatever x axis movement you'd like
       
    }

    void jump() {
        //robot.velocity = new Vector2(robot.velocity.x, 7);
        //canJump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }

}
