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
    Vector2 move;
  
    public float jumpForce = 5f; // Force applied for jump


    void FixedUpdate()
    {
        movement();
    }

  
protected virtual void movement()
    {
        move.x = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
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

