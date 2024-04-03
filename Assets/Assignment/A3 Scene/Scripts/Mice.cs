using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mice : CharBehave
    {
    SpriteRenderer spriteRenderer;
    static float jumpHeight = 3.0f; // made static so all objects would jump at the same height and duration.The height the object will jump
    static float duration = 0.5f; // The duration of the jump
    Coroutine coroutine;
    public Vector3 ogPosition;
    void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        ogPosition = transform.position;
        StartCoroutine(Jump());
    }

        protected override void OnCollisionEnter2D(Collision2D collision)
        {
            //start the coroutine when a collision is detected
            StartCoroutine(MiceCaught());
        }

        IEnumerator MiceCaught()
        {
        // Change the color to blue after collision
        spriteRenderer.color = Color.blue;
            // Wait for 2 secs
            yield return new WaitForSeconds(2);
            // Call the base class method to destroy the GameObject
            base.destroyGameobject();
        }

  IEnumerator Jump()
    {
        ogPosition = transform.position;
        while (true) // Creates a loop for jump mechanic for mice 
        {
            // Move up
            float timer = 0.0f;
            Vector3 startPosition = transform.position;
            Vector3 endPosition = ogPosition + Vector3.up * jumpHeight;

            while (timer < duration)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, timer / duration);
                timer += Time.deltaTime;
                yield return null; // Wait for the next frame 
            }
            transform.position = endPosition;
            // Wait for 0.4 seconds at the top of the jump
            yield return new WaitForSeconds(0.4f);
            // Move down
            timer = 0.0f;
            startPosition = transform.position;
            endPosition = ogPosition;
            while (timer < duration)
            {
                transform.position = Vector3.Lerp(startPosition, endPosition, timer / duration);
                timer += Time.deltaTime;
               yield return null;
            }
            transform.position = endPosition;
            // Wait for 3 seconds before jumping again
            yield return new WaitForSeconds(3);
        }
    }
}


