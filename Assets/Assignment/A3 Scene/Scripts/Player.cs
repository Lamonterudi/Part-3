using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Player : CharBehave
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Vector2 move; //makes it accessible in child class for jumping

    //so the ally script can access this
    protected virtual void FixedUpdate()
    {
        movement();
        //will destroy game obeject if player presses y
        if (Input.GetKey(KeyCode.Y))
        {
            base.destroyGameobject();
        }
    }

  //so the child classes can access this movement script 
protected virtual void movement() { 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3(moveHorizontal * speed, rb.velocity.y, 0.0f);
    }
}

    //overrides the character behaviour and makes it not get destroyed on collision so player can keep playing while collecting rats. 
    //additionally if player falls off map then it will get destroyed and be game over 

    protected override void OnCollisionEnter2D(Collision2D collision)
    { 
        if (transform.position.y <= -3)
        {
            //will load gameover screen if you fall off screen 
           SceneManager.LoadScene(2);
        }
         
    }
}


