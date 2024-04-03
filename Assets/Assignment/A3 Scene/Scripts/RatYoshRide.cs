using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatYoshRide : Player
{

    public float rideJumpSpeed = 10f;
    public float jumpHeight = 15f;
    private bool rideJump = false;  //starts character not jumping
    private float startingscale = 0.1f; //starts character extremely tiny 
 
    // Start is called before the first frame update
    void Start()
    {
        //initial local scale for yoshi riding before it instantiaes bigger 
        rb.transform.localScale = Vector3.one* startingscale;
      
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rideJump==false)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, 0);
            rideJump = true;
        }
    }
    void FixedUpdate()
    {
        //then enables movement for player while riding
        base.movement();
        //increases size to my desired scale for object
        if (Input.GetKey(KeyCode.Y))
        {
            //changes the object scale back to its size and instantiates it to the starting position of game. 
            rb.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one * 4, 1f);
            rb.transform.position = new Vector3(-6.24f, -2.31f, rb.transform.position.z);
        }

    }
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        //makes it so when yoshis feet touch ground then he can jump 
            rideJump = false;
        //inherites the gameover from player script 
        base.OnCollisionEnter2D(collision);


    }
}

